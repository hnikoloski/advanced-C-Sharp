using System;
using System.Diagnostics;

namespace Converter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" Chose your converter: \n 1) Gallons to liters \n 2)Liters to gallons ");
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Enter your gallon value");
                    var gallonsValue = Console.ReadLine();


                    Console.WriteLine(
                        $"\n{gallonsValue} Gallons is {GallonsToLiters.GallonsToLiterConversion(gallonsValue)} Liters");
                    break;
                case "2":
                    Console.WriteLine("Enter your liter value");
                    var literValue = Console.ReadLine();

                    Console.WriteLine(
                        $"\n{literValue} Liters is {GallonsToLiters.GallonsToLiterConversion(literValue)} Gallons");
                    break;

                default:
                    Console.WriteLine("Invalid choice. \n Please chose from 1 or 2");
                    break;
            }

            Console.WriteLine("\n Smestaj dan trebit? Y/N");
            var smestaj = Console.ReadLine().ToUpper();
            switch (smestaj)
            {
                case "Y":
                    Process.Start(@"http://lmgtfy.com/?q=Smestaj+ohrid");
                    break;
                case "N":
                    break;
            }
        }
    }
}