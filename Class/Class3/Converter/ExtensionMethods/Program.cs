using System;

namespace ExtensionMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = "Random Text";
            Console.WriteLine($"{text} \n{text.GetQuotes()}");

            Console.ReadLine();
        }
    }
}