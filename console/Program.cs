using System;

namespace console
{
    public class Program
    {
        public static Product[] products = new Product[10];
        
        public static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Product p = new Product { Name = "Car-" + i, Price = 20000 + (i * 10) };
                products[i] = p;
                Console.WriteLine("Create product: " + p.ToString());
            }
            
            Console.WriteLine("done!");
            Console.ReadLine();
        }
    }
}
