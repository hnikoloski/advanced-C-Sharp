using System;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Part {Name = "HDD", Price = 30.0};
            var p2 = new Part {Name = "HDD SSD", Price = 120.0};
            var p3 = new Part {Name = "HDD Data Cable", Price = 15.25};
            var p4 = new Part {Name = "HDD Power cable", Price = 5.25};
            var p5 = new Part {Name = "HDD External Box", Price = 9.0};
            var p6 = new Part {Name = "HDD Usb cable", Price = 3.25};
            var p7 = new Part {Name = "HDD Connector", Price = 2.25};
            var p8 = new Part {Name = "Camera external", Price = 15.0};
            var p9 = new Part {Name = "HDMI cable", Price = 20.5};
            var p10 = new Part {Name = "VGA cable", Price = 4.25};
            var p11 = new Part {Name = "USB cable", Price = 3.25};
            var p12 = new Part {Name = "Wifi Mouse", Price = 5.25};
            var p13 = new Part {Name = "Wifi Keyboard", Price = 5.25};
            var p14 = new Part {Name = "Desk mont part", Price = 15.25};
            var p15 = new Part {Name = "Monitor", Price = 115.25};
            var p16 = new Part {Name = "Cooler", Price = 7.25};
            var p17 = new Part {Name = "RAM", Price = 45.25};
            var p18 = new Part {Name = "Graphic card", Price = 86.25};
            var p19 = new Part {Name = "CPU", Price = 95.25};
            var p20 = new Part {Name = "Motherboard", Price = 85.0};
            var p21 = new Part {Name = "PC box", Price = 35.0};
            var p22 = new Part {Name = "Wifi sound", Price = 19.0};

            #region HDD module

            var m1 = new Module("HDD module");
            m1.AddPartToModule(p1, 1); //HDD
            m1.AddPartToModule(p2, 1); //HDD SSD
            m1.AddPartToModule(p3, 2); //two data cables
            m1.AddPartToModule(p4, 1); //hdd power cable
            m1.AddPartToModule(p6, 1); //HDD usb cable
            m1.AddPartToModule(p7, 1); //HDD connector

            m1.SetDiscount(10); // 10%
            Console.WriteLine("Module 1: {0}", m1.Name);
            Console.WriteLine($"Module1 price without discount:{m1.GetPrice()}");
            Console.WriteLine("Discount price: {0}", m1.GetPriceWithDiscount().PriceWithCurrency("EUR"));

            //Console.WriteLine(m1.GetPrice().PriceWithCurrency("EUR"));
            //Console.WriteLine("Discount price: {0}", m1.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            #endregion

            #region Peripherals module

            var m2 = new Module("Perhipherals");
            Console.WriteLine("Module 2: {0}", m2.Name);
            m2.AddPartToModule(p12, 1); //wifi mouse
            m2.AddPartToModule(p13, 1); //wifi Keyboard
            m2.AddPartToModule(p16, 1); //cooler
            m2.AddPartToModule(p22, 1); //wifi sound
            m2.AddPartToModule(p9, 1); //HDMI cable for the second monitor of the configuration
            m2.SetDiscount(5); // 5%
            Console.WriteLine($"Module2 price without discount:{m2.GetPrice()}");

            // Console.WriteLine(m2.GetPrice().PriceWithCurrency("EUR"));
            // Console.WriteLine("Discount price: {0}", m2.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            #endregion

            #region Configuration 1

            var pc1 = new Configuration(Colors.Black); //pc configuration
            pc1.Name = "Configuration 1";
            //add modules to configuration 
            pc1.AddModuleToProduct(m1, 1);
            pc1.AddModuleToProduct(m2, 1);

            //add parts to configuration
            pc1.AddPartToProduct(p15, 2); //Monitors x2
            pc1.AddPartToProduct(p17, 1); //RAM
            pc1.AddPartToProduct(p18, 1); //Graphic card
            pc1.AddPartToProduct(p20, 1); //Motherboard
            pc1.AddPartToProduct(p19, 1); //CPU
            pc1.AddPartToProduct(p21, 1); //PC box

            Console.WriteLine(pc1.Name);
            Console.WriteLine("Box color: {0}", pc1.BoxColor);
            Console.WriteLine($"First PC price:{pc1.GetPrice()}");
            pc1.SetDiscount(5); // 5%
            //Console.WriteLine($"{pc1.GetPrice().PriceWithCurrency("EUR")}");            
            //Console.WriteLine("Discount price: {0}", pc1.GetPriceWithDiscount().PriceWithCurrency("EUR"));
            Console.WriteLine("--------------------");

            #endregion

            Console.ReadLine();
        }
    }
}