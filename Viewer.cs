using System;
using System.Text.RegularExpressions;

namespace HtlmEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Visualization mode");
            Menu.Line(50);
            Replace(text);
            Menu.Line(50);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong);
        }
    }
}