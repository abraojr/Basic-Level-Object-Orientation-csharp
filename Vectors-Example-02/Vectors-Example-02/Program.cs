using System;
using System.Globalization;

namespace Vectors_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read an integer N and the data (name and price) of N Products. Store the N products in a vector. 
             *Then, show the average price of the products.*/

            Console.Write("Quantity of products: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Product name: ");
                string name = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                Console.WriteLine();
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
