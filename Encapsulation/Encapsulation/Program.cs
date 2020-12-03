using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of a product in stock (name, price and quantity in stock). Then:
              * • Show product data (name, price, quantity in stock, total value in stock)
              * • Make a stock entry and show the product data again
              * • Make a check in the stock and show the product data again*/

            Product p = new Product("TV", 900.00, 10);

            p.SetName("TV 4K");

            Console.WriteLine("Product name: " + p.GetName());// OUTPUT: TV 4K
            Console.WriteLine("Product price: U$ " + p.GetPrice());
            Console.WriteLine("Product quantity in inventory: " + p.GetQuantity());
            Console.WriteLine("----------------------------------------------------------");

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
