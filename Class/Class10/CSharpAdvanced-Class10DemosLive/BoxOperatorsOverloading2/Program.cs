using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOperatorsOverloading2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            #region BasicOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- ++b1 Operator -----------");
            //++b1;
            //b1.PrintBox();

            //Console.WriteLine("\n----------- --b1 Operator -----------");
            //--b1;
            //b1.PrintBox();

            //int x = -5;
            //int y = 10;
            //y = -x;
            //Console.WriteLine($"x: {x}, y: {y}");

            //Console.WriteLine("\n----------- !b1 Operator -----------");
            //Console.WriteLine($"! Operator: {!b1}");

            //Console.WriteLine("\n----------- b1 + b2 Operator -----------");
            //Box b3 = b1 + b2;
            //b3.PrintBox();

            //Console.WriteLine("\n----------- b1 - b2 Operator -----------");
            //Box b4 = b1 - b2;
            //b4.PrintBox();

            //Console.WriteLine("\n----------- b1 * b2 Operator -----------");
            //Box b5 = b1 * b2;
            //b5.PrintBox();

            //Console.WriteLine("\n----------- b1 / b2 Operator -----------");
            //Box b6 = b1 / b2;
            //b6.PrintBox();

            //Console.WriteLine("\n----------- b1 % b2 Operator -----------");
            //Box b7 = b1 % b2;
            //b7.PrintBox();

            //Console.ReadLine();
            #endregion

            #region LogicalOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- b1 & b2 Operator -----------");
            //Box b3 = b1 & b2;
            //b3.PrintBox();

            //Console.WriteLine("\n----------- b1 | b2 Operator -----------");
            //Box b4 = b1 | b2;
            //b4.PrintBox();

            //Console.WriteLine("\n----------- b1 ^ b2 Operator -----------");
            //Box b5 = b1 ^ b2;
            //b5.PrintBox();

            //Console.ReadLine();
            #endregion

            #region RelationalOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- b1 == b2 Operator -----------");
            //Console.WriteLine($"b1 == b2: {b1 == b2}");

            //Console.WriteLine("\n----------- b1 != b2 Operator -----------");
            //Console.WriteLine($"b1 != b2: {b1 != b2}");

            //Console.WriteLine("\n----------- b1 > b2 Operator -----------");
            //Console.WriteLine($"b1 > b2: {b1 > b2}");

            //Console.WriteLine("\n----------- b1 < b2 Operator -----------");
            //Console.WriteLine($"b1 < b2: {b1 < b2}");

            //Console.WriteLine("\n----------- b1 >= b2 Operator -----------");
            //Console.WriteLine($"b1 >= b2: {b1 >= b2}");

            //Console.WriteLine("\n----------- b1 <= b2 Operator -----------");
            //Console.WriteLine($"b1 <= b2: {b1 <= b2}");

            //Console.ReadLine();
            #endregion

            int x = 10;
            int y = 15;
            int z = 20;

            Box box1 = new Box(x, y,z);
            Box box2 = new Box(x, y, z);
            var result1 = box1 + box2;
            Console.WriteLine($"Result1 = box1 + box2");
            result1.PrintBox();
            Console.WriteLine("---------------------------------------");
            var result2 = box1 > box2;
            Console.WriteLine($"Result2 = box1>box2 \n{result2}---------------------------------------");
            



            Console.ReadKey();

        }
    }
}
