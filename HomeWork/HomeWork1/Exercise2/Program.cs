using System;

namespace Exercise2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var exitOpt = "";
            while (exitOpt != "Y")
            {
                Console.WriteLine("Enter something and see if it is a number");
                var userInput = Console.ReadLine();
                Console.WriteLine($"\n\n{userInput.CheckDigit()}");

                Console.WriteLine("\n\nDo you want to exit ? Y/N \n ");
                var exitOptInput = Console.ReadLine().ToUpper();

                if (exitOptInput == "N") exitOpt = "N";
                if (exitOptInput == "Y") exitOpt = "Y";
            }
        }
    }
}