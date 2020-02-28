using System;

namespace GitHookTestConsole
{
    internal class Program
    {
        private readonly IText _text;

        private static void Main(string[] args)
        {
            IText text = new Text();

            string result = text.Concat("Hop", "Scotch");

            Console.WriteLine("Hello World!");
        }
    }
}