using System;
using System.Globalization;

namespace Methods_02_Using_object_and_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of a product in stock (name, price and quantity in stock). Then:
              * • Show product data (name, price, quantity in stock, total value in stock)
              * • Make a stock entry and show the product data again
              * • Make a check in the stock and show the product data again*/

            Product p = new Product();

            Console.WriteLine("Enter the product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: U$ ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in inventory: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Product data: " + p);
            Console.WriteLine();

            Console.Write("Enter the number of products to be added to inventory: ");
            int qntity = int.Parse(Console.ReadLine());
            p.AddProducts(qntity);
            Console.WriteLine("Updated data: " + p);
            Console.WriteLine();

            Console.Write("Enter the number of products to be removed to inventory: ");
            qntity = int.Parse(Console.ReadLine());
            p.RemoveProducts(qntity);
            Console.Write("Updated data: " + p);
            Console.WriteLine();
        }
    }
}
