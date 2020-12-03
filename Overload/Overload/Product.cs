using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Overload
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        //Standard constructor.
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        //First constructor overloading
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 5;
        }
        public double TotalValueInStock()
        {
            return Price * Quantity;
        }
        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }
        public override string ToString()
        {
            return Name
            + ", U$ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " units, Total: U$ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
