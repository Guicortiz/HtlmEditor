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
    }
}