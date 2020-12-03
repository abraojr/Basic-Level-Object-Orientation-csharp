using System;
using System.Globalization;

namespace Keyword_This
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of a product in stock(name, price and quantity in stock).Then:
              * • Show product data(name, price, quantity in stock, total value in stock)
              * • Make a stock entry and show the product data again
              * • Make a check in the stock and show the product data again*/

            Console.WriteLine("Enter the product data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: U$ ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product(name, price, 10);
            Console.WriteLine();

            Console.WriteLine("Product data: " + p);
            Console.WriteLine();

            Console.Write("Enter the number of products to be added to inventory: ");
            int qntity = int.Parse(Console.ReadLine());
            p.AddProducts(qntity);
            Console.WriteLine();

            Console.WriteLine("Updated data: " + p);
            Console.WriteLine();

            Console.Write("Enter the number of products to be removed to inventory: ");
            qntity = int.Parse(Console.ReadLine());
            p.RemoveProducts(qntity);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);
        }
    }
}
