from pathlib import Path

ROOT = Path(r"E:\BeamPy\lexus_is300")

IMAGE_EXT = {".png", ".jpg", ".jpeg", ".gif", ".bmp", ".webp", ".tiff"}
MODEL_EXT = {".dae", ".dts", ".obj", ".fbx", ".gltf", ".glb", ".stl", ".ply"}
TEXT_EXT  = {".jbeam", ".txt", ".json", ".xml", ".csv", ".md", ".py", ".ini",
             ".yaml", ".yml", ".log", ".html", ".css", ".js", ".mtl", ".pc", ".json5"}


def human_size(n: int) -> str:
    for unit in ["B", "KB", "MB", "GB"]:
        if n < 1024:
            return f"{n:.1f} {unit}"
        n /= 1024
    return f"{n:.1f} TB"


def file_kind(p: Path) -> str:
    ext = p.suffix.lower()
    if p.name.lower().endswith(".cached.dts"):
        return "[MODEL]"
    if ext in IMAGE_EXT:
        return "[IMG]"
    if ext in MODEL_EXT:
        return "[MODEL]"
    if ext in TEXT_EXT:
        return "[TEXT]"
    return "[OTHER]"


def walk(folder: Path, level: int = 0):
    indent = "    " * level
    try:
        entries = sorted(folder.iterdir(), key=lambda x: (x.is_file(), x.name.lower()))
    except PermissionError:
        print(f"{indent}[нет доступа]")
        return

    for entry in entries:
        if entry.is_dir():
            count = sum(1 for _ in entry.rglob("*") if _.is_file())
            print(f"\n{indent}📁 {entry.name}/  ({count} файлов)")
            walk(entry, level + 1)
        else:
            size = entry.stat().st_size
            kind = file_kind(entry)
            print(f"\n{indent}{kind} {entry.name}  — {human_size(size)}")
            if kind == "[TEXT]":
                print(f"{indent}--- содержимое ---")
                try:
                    with open(entry, "r", encoding="utf-8", errors="replace") as f:
                        print(f.read())  # ВЕСЬ файл целиком
                except Exception as e:
                    print(f"{indent}[ошибка чтения: {e}]")
                print(f"{indent}--- конец ---")


if __name__ == "__main__":
    if not ROOT.exists():
        print(f"Папка не найдена: {ROOT}")
    else:
        all_files = [p for p in ROOT.rglob("*") if p.is_file()]
        total = sum(p.stat().st_size for p in all_files)
        folders = [p for p in ROOT.rglob("*") if p.is_dir()]
        print(f"Корень: {ROOT}")
        print(f"Файлов: {len(all_files)}   Папок: {len(folders)}   Размер: {human_size(total)}")
        print("=" * 100)
        walk(ROOT)
