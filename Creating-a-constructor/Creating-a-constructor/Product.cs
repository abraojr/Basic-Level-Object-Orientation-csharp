using System.Globalization;

namespace Creating_a_constructor
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        //The constructor has the same name as the class.
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
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
