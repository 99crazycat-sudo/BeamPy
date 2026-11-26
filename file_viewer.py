"""
Просмотр файлов проекта lexus_is300.
Запускается через main.py или напрямую: python file_viewer.py
"""
from pathlib import Path
from beam_parser import load_jbeam

ROOT = Path(__file__).parent / "lexus_is300"

IMAGE_EXT = {".png", ".jpg", ".jpeg", ".gif", ".bmp", ".webp", ".tiff"}
MODEL_EXT = {".dae", ".dts", ".obj", ".fbx", ".gltf", ".glb", ".stl", ".ply"}
TEXT_EXT  = {".jbeam", ".cs", ".txt", ".json", ".xml", ".csv", ".md", ".py",
             ".ini", ".yaml", ".yml", ".log", ".html", ".css", ".js", ".mtl",
             ".pc", ".json5", ".lua", ".cfg", ".material"}


def human_size(n: int) -> str:
    for unit in ["B", "KB", "MB", "GB"]:
        if n < 1024:
            return f"{n:.1f} {unit}"
        n /= 1024
    return f"{n:.1f} TB"


def file_kind(p: Path) -> str:
    ext = p.suffix.lower()
    if p.name.lower().endswith(".cached.dts"):
        return "MODEL"
    if ext in IMAGE_EXT:
        return "IMG"
    if ext in MODEL_EXT:
        return "MODEL"
    if ext in TEXT_EXT:
        return "TEXT"
    return "OTHER"


def list_tree(folder: Path = ROOT, level: int = 0):
    indent = "    " * level
    try:
        entries = sorted(folder.iterdir(), key=lambda x: (x.is_file(), x.name.lower()))
    except PermissionError:
        print(f"{indent}[нет доступа]")
        return
    for entry in entries:
        if entry.is_dir():
            count = sum(1 for _ in entry.rglob("*") if _.is_file())
            print(f"{indent}📁 {entry.name}/  ({count} файлов)")
            list_tree(entry, level + 1)
        else:
            size = entry.stat().st_size
            print(f"{indent}[{file_kind(entry)}] {entry.name}  — {human_size(size)}")


def show_file(rel_path: str):
    p = ROOT / rel_path
    if not p.exists():
        print(f"Файл не найден: {p}")
        return
    kind = file_kind(p)
    print(f"[{kind}] {p.name}  — {human_size(p.stat().st_size)}\n")
    if kind == "TEXT":
        try:
            print(p.read_text(encoding="utf-8", errors="replace"))
        except Exception as e:
            print(f"[ошибка чтения: {e}]")
    elif kind in ("IMG", "MODEL"):
        print(f"Открываю: {p}")
        try:
            import os
            os.startfile(p)  # Windows
        except Exception as e:
            print(f"[не удалось открыть: {e}]")
    else:
        print(f"Неизвестный тип: {p.suffix}")


def show_jbeam_structure(rel_path: str):
    p = ROOT / rel_path
    if not p.exists():
        print(f"Файл не найден: {p}")
        return
    try:
        data = load_jbeam(p)
    except Exception as e:
        print(f"[не удалось распарсить: {e}]")
        return

    print(f"Структура {p.name}:")
    print(f"  Ключи верхнего уровня: {list(data.keys())}")
    for part_name, part in data.items():
        if not isinstance(part, dict):
            continue
        info = part.get("information", {})
        print(f"\n  ── {part_name} ──")
        if info:
            print(f"     authors: {info.get('authors')}")
            print(f"     name:    {info.get('name')}")
        for k in ("slotType", "selfCollisionThickness", "remoteCollisionThickness"):
            if k in part:
                print(f"     {k}: {part[k]}")
        for arr in ("slots", "nodes", "beams", "flexbodies", "props"):
            if arr in part and isinstance(part[arr], list):
                print(f"     {arr}: {len(part[arr])} элементов")


def stats():
    if not ROOT.exists():
        print(f"Папка не найдена: {ROOT}")
        return
    files = [p for p in ROOT.rglob("*") if p.is_file()]
    folders = [p for p in ROOT.rglob("*") if p.is_dir()]
    total = sum(p.stat().st_size for p in files)
    print(f"Папка:  {ROOT}")
    print(f"Файлов: {len(files)}")
    print(f"Папок:  {len(folders)}")
    print(f"Размер: {human_size(total)}")
    by_kind = {}
    for p in files:
        k = file_kind(p)
        by_kind[k] = by_kind.get(k, 0) + 1
    print("\nПо типам:")
    for k, v in sorted(by_kind.items()):
        print(f"  {k}: {v}")


def menu():
    if not ROOT.exists():
        print(f"❌ Папка не найдена: {ROOT}")
        return
    while True:
        print("\n" + "=" * 50)
        print("File Viewer")
        print("=" * 50)
        print("1. Дерево файлов")
        print("2. Показать файл")
        print("3. Структура .jbeam")
        print("4. Статистика")
        print("0. Назад")
        choice = input("\nВыбор: ").strip()

        if choice == "1":
            list_tree()
        elif choice == "2":
            rel = input("Путь относительно lexus_is300/: ").strip()
            show_file(rel)
        elif choice == "3":
            rel = input("Путь к .jbeam: ").strip()
            show_jbeam_structure(rel)
        elif choice == "4":
            stats()
        elif choice == "0":
            break
        else:
            print("Не понял.")


if __name__ == "__main__":
    menu()
