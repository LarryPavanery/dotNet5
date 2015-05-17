using System;
using System.Collections.Generic;

namespace console
{
    public class Program
    { 
        public static List<Product> products = new List<Product>();
        public static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Product p = new Product { Name = "Car-" + i, Price = 20000 + (i * 10) };
                products.Add(p);
                Console.WriteLine("Create product: " + p.ToString());
            }
            
            Console.WriteLine("done!");
            Console.ReadLine();
        }
    }
}
