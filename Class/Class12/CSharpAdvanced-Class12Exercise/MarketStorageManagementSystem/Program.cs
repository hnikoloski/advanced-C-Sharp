﻿using Models;
using Models.Enums;
using Models.Models;
using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace MarketStorageManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "HDD", Color.Black, Channel.Local, new SerialInfo("S001PN1", 1), new MarketValueDetails(10, 1000.50), ProductionCondition.New, new List<string>(){ "Macedonia", "Iraq"}),
                new Product(2, "CPU", Color.Gray, Channel.Local, new SerialInfo("S001PN111", 12), new MarketValueDetails(12, 500.70), ProductionCondition.Recycled, new List<string>(){ "China", "Iraq", "Iran", "Brazil"}),
                new Product(3, "SSD", Color.Gray, Channel.Online, new SerialInfo("S001PN9", 11), new MarketValueDetails(4, 780.99), ProductionCondition.New, new List<string>(){ "Macedonia", "Hungary"}),
                new Product(4, "CPU", Color.Black, Channel.Local, new SerialInfo("S001PN8", 10), new MarketValueDetails(8, 800.00), ProductionCondition.Recycled, new List<string>(){ "Albania", "Serbia"}),
                new Product(5, "Motherboard", Color.Yellow, Channel.Online, new SerialInfo("S002PN10", 5), new MarketValueDetails(2, 1500.50), ProductionCondition.New, new List<string>(){ "Angola", "Algeria", "American Samoa"}),
                new Product(6, "VideoCard", Color.Green, Channel.Online, new SerialInfo("S002PN9", 5), new MarketValueDetails(9, 999.99), ProductionCondition.Recycled, new List<string>(){ "Cameroon", "Iraq"}),
                new Product(7, "PowerSuply", Color.Red, Channel.Local, new SerialInfo("S002PN11", 6), new MarketValueDetails(1, 500.65), ProductionCondition.New, new List<string>(){ "Macedonia", "Denmark", "Norway"}),
                new Product(8, "RAM", Color.Green, Channel.Online, new SerialInfo("S003PN1", 3), new MarketValueDetails(14, 2700.67), ProductionCondition.Recycled, new List<string>(){ "Romania", "Russia", "Qatar"}),
                new Product(9, "Keyboard", Color.Black, Channel.Online, new SerialInfo("S004PN1", 9), new MarketValueDetails(6, 400.44), ProductionCondition.New, new List<string>(){ "Macedonia", "Russia", "Morocco", "Malta"}),
                new Product(10, "Mouse", Color.Orange, Channel.Local, new SerialInfo("S005PN234", 2), new MarketValueDetails(5, 67.89), ProductionCondition.Recycled, new List<string>(){ "Nigeria", "Peru"}),
                new Product(11, "Speaker", Color.White, Channel.Local, new SerialInfo("S007PNSG54", 1), new MarketValueDetails(50, 2300.11), ProductionCondition.New, new List<string>(){ "Portugal", "Poland", "Spain"}),
            };
           

            var path = @"C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\advancedC#\Class\Class12\GeneratedFiles\products.txt";
            FileInfo productsList = new FileInfo(path);
            using (StreamWriter sw = productsList.CreateText())
            {
                foreach (var item in products)
                {
                    sw.WriteLine(item.ToString());
                }
               
            }

            #region Console Read 1



            //using (StreamReader sr = productsList.OpenText())
            //{
            //    string log = "";
            //    while ((log = sr.ReadLine()) != null)
            //    {
            //        foreach (var item in products)
            //        {

            //        Console.WriteLine(item);
            //        }
            //    }
            //}
            #endregion

            #region XML Serilize and Deserilize

            //var serializer = new XmlSerializer(products.GetType());
            //var path2 = @"C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\advancedC#\Class\Class12\GeneratedFiles\products.xml";
            //using (StreamWriter sw = new StreamWriter(path2))
            //{
            //    serializer.Serialize(sw,products);
            //}

            //List<Product> deProduct;
            //using (StreamReader sr = new StreamReader(path2))
            //{
            //    deProduct = (List<Product>)serializer.Deserialize(sr);
            //    foreach (var item2 in deProduct )
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}

            #endregion

            #region Json
            var pathJson = @"C:\Users\Hristijan.nikoloski\Desktop\Hristijan.Nikoloski\advancedC#\Class\Class12\GeneratedFiles\products.JSON";
            
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(pathJson, json);

            //De
            List<Product> deJsonProducts;
            string readJson = File.ReadAllText(pathJson);
            deJsonProducts = JsonConvert.DeserializeObject<List<Product>>(readJson);
            foreach (var e in deJsonProducts)
            {
                Console.WriteLine(e.ToString());
            }






            #endregion
            Console.ReadLine();
        }
    }
}
