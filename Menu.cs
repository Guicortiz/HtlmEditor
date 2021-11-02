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
        }

        public static void DrawScreen()
        {
            Header(50);
            Body(50, 15);
            Header(50);
        }

        public static void Header(int width)
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
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
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
    }
}