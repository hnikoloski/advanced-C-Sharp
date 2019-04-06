using System;

namespace Exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // Exercise 3 is not Done ...
            //Console.WriteLine("Enter Something...");
            var userInput = 123;
            Console.WriteLine(
                "Do you want to: \n1)Check if it is valid numeric type \n2)Check the exact type of the input");
            var methodChoice = Console.ReadLine();
            switch (methodChoice)
            {
                case "1":
                    Console.WriteLine(userInput.IsNumericType());
                    break;
                case "2":
                    Console.WriteLine(userInput.IsNotNumericType());
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadLine();
        }
    }
}