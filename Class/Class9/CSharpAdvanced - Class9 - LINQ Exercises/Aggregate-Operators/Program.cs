using System;
using System.Collections.Generic;
using System.Linq;
using DataFromXml;

namespace Aggregate_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Find all orders with 'VINET' Customer ID and print how many orders we have from each type.
            //var result = orders.Where(o => o.CustomerID == "VINET");

            //var i = 0;
            //foreach (var o in result)
            //{
            //    i++;
            //    Console.WriteLine($" {i}) ID:{o.CustomerID} Freight: {o.Freight}");
            //    Console.WriteLine(" _________________________________________________________________________");
            //}
            var result = orders.GroupBy(c => c.CustomerID)
                .Select(p => new { p = p.Key, count = p.Count() });
            //foreach (var c in result)
            //{
            //    Console.WriteLine(c);
            //}




            //2Print the count of all orders per different Customer ID

            var differentId = orders.GroupBy(c => c.CustomerID)
                            .Select( p=> new {p=p.Key, count=p.Count()});
            //foreach (var c in differentId)
            //{
            //Console.WriteLine(c);
            //}

            //3 Print the count and total Freight of all orders with 'VINET' Customer ID


            var totalFreight = orders.GroupBy(c => c.CustomerID == "Vinet")
                .Select(p => new {p = p.Key, count = p.Count(), total=p.Sum(s=>s.Freight)});
            foreach (var c in totalFreight)
            {
                Console.WriteLine(c);
            }

            //Console.WriteLine($"Totalk orders with VINET id: {totalFreightOrders}");

            //Print the order with 'VINET' Customer ID identified by the minimal Freight 

            //Print all orders per different Ship Country identified by the maximum Freight 

            //Print the average Freight (with two decimals) for all orders

            Console.ReadKey();


        }
    }
}