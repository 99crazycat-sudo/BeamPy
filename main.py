"""
BeamPy — точка входа.
Запуск: python main.py
"""
def menu():
    while True:
        print("\n" + "=" * 50)
        print("BeamPy")
        print("=" * 50)
        print("1. Просмотр файлов (file_viewer)")
        print("2. Физическая симуляция (physics)")
        print("0. Выход")
        choice = input("\nВыбор: ").strip()

        if choice == "1":
            import file_viewer
            file_viewer.menu()
        elif choice == "2":
            import physics
            physics.main()
        elif choice == "0":
            break
        else:
            print("Не понял.")


if __name__ == "__main__":
    menu()
