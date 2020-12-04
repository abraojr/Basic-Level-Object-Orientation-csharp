using System;
using System.Globalization;

namespace Ternary_conditional_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Product price: U$ ");
            double price = double.Parse(Console.ReadLine());

            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine("Discount= U$ " + discount.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
