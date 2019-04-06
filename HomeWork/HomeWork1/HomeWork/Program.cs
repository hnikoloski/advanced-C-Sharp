using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var exitOpt = "";
            while (exitOpt != "Y")
            {
                Console.WriteLine(
                    "  Write something. And trough the magic of C# you shall receive it back With Quotes.");
                var userInputString = Console.ReadLine();
                Console.WriteLine($"\n\n{userInputString.QuoteString()} \n \nThose are some nice quotes\n\n");

                Console.WriteLine("Do you want to exit ? Y/N");
                var exitOptInput = Console.ReadLine().ToUpper();

                if (exitOptInput == "N") exitOpt = "N";
                if (exitOptInput == "Y") exitOpt = "Y";
            }
        }
    }
}