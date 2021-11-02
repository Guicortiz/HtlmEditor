using System;
using System.Text;

namespace HtlmEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Mode Editor");
            Menu.Line(50);
            Console.Write("\n");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Menu.Line(50);
            Console.WriteLine("| Do you want save changes to file");
            Viewer.Show(file.ToString());
        }
    }
}