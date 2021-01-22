using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shop = new Dictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                string curShop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shop.ContainsKey(curShop))
                {
                    shop.Add(curShop, new Dictionary<string, double>());
                    shop[curShop].Add(product, price);

                }
                else
                {
                    shop[curShop].Add(product, price);
                }


                input = Console.ReadLine().Split(", ");
            }

            foreach (var item in shop.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var productAndPrice in item.Value)
                {
                    Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value:f}");
                }

            }
        }
    }
}
