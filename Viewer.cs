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
            Console.Write("\n");
            Replace(text);
            Console.Write("\n");
            Menu.Line(50);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');


            foreach (var word in words)
            {
                if (strong.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        word.Substring(
                            word.IndexOf('>') + 1,
                            (
                                (word.LastIndexOf('<') - 1) -
                                word.IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(word);
                    Console.Write(" ");
                }
            }
        }
    }
}