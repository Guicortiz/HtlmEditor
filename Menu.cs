using System;

namespace HtlmEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Line(50);
            Body(50, 15);
            Line(50);
        }

        public static void Line(int width)
        {
            Console.Write("+");
            for (int i = 0; i <= width; i++) Console.Write("-");
            Console.Write("+");
        }

        public static void Body(int width, int height)
        {
            Console.Write("\n");
            for (int lines = 0; lines < height; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= width; i++) Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Htlm Editor");
            Console.SetCursorPosition(0, 3);
            Line(50);
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Select one of the following options:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - New file");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open file");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Exit application");
            Console.SetCursorPosition(3, 11);
            Console.Write("Option:");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Menu.Show(); break;
            }
        }
    }
}