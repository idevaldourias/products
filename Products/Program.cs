using Products.Entities;
using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customs));
                } 
                else if (type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, dateManufacture));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}