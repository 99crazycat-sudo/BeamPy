"""
Общий парсер BeamNG .jbeam → Python-структуры.
Используется и file_viewer.py, и physics.py.
"""
import json
import re
from pathlib import Path


def strip_jbeam(text: str) -> str:
    """BeamNG .jbeam → валидный JSON (убираем комментарии и висячие запятые)."""
    text = re.sub(r'//[^\n]*', '', text)
    text = re.sub(r'/\*.*?\*/', '', text, flags=re.S)
    text = re.sub(r',(\s*[\]}])', r'\1', text)
    return text


def load_jbeam(path: Path) -> dict:
    """Читает .jbeam и возвращает распарсенный dict."""
    raw = Path(path).read_text(encoding="utf-8", errors="replace")
    return json.loads(strip_jbeam(raw))


def extract_nodes_beams(path: Path):
    """
    Извлекает ноды и балки из первой подходящей части .jbeam.
    Возвращает:
        nodes: dict id -> {"pos": [x,y,z], "mass": float, "collision": bool}
        beams: list of {"a": id, "b": id, "rest_length": float,
                         "spring", "damp", "deform", "strength"}
    """
    data = load_jbeam(path)
    for part_name, part in data.items():
        if not isinstance(part, dict):
            continue
        if "nodes" not in part or "beams" not in part:
            continue

        # --- ноды ---
        nodes = {}
        cur_mass, cur_collision = 10.0, True
        for item in part["nodes"]:
            if isinstance(item, dict):
                if "nodeWeight" in item:
                    cur_mass = float(item["nodeWeight"]) * 10.0
                if "collision" in item:
                    cur_collision = bool(item["collision"])
            elif isinstance(item, list) and len(item) >= 4:
                try:
                    nodes[item[0]] = {
                        "pos": [float(item[1]), float(item[2]), float(item[3])],
                        "mass": cur_mass,
                        "collision": cur_collision,
                    }
                except (ValueError, IndexError):
                    pass

        # --- балки ---
        beams = []
        spring, damp, deform, strength = 1e6, 200.0, 5e4, 1e15
        for item in part["beams"]:
            if isinstance(item, dict):
                if "beamSpring" in item: spring = float(item["beamSpring"])
                if "beamDamp" in item: damp = float(item["beamDamp"])
                if "beamDeform" in item:
                    v = item["beamDeform"]
                    deform = 1e15 if v == "FLT_MAX" else float(v)
                if "beamStrength" in item:
                    v = item["beamStrength"]
                    strength = 1e15 if v == "FLT_MAX" else float(v)
            elif isinstance(item, list) and len(item) >= 2:
                a, b = item[0], item[1]
                if a in nodes and b in nodes:
                    pa, pb = nodes[a]["pos"], nodes[b]["pos"]
                    rest = ((pa[0]-pb[0])**2 + (pa[1]-pb[1])**2 + (pa[2]-pb[2])**2) ** 0.5
                    beams.append({
                        "a": a, "b": b,
                        "rest_length": rest,
                        "spring": spring, "damp": damp,
                        "deform": deform, "strength": strength,
                    })

        return nodes, beams

    raise RuntimeError(f"В {path} нет частей с nodes+beams")
