using System.Globalization;

namespace Encapsulation
{
    class Product
    {
        // The auto-properties are a simplified way to declare properties that do not require  a particular logic for get and set operations. 
        private string _name;
        public double Price { get; private set; }
        public double Quantity { get; set; }

        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }   
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public double TotalValueInStock
        {
            get { return Price * Quantity; }
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
            return _name
            + ", U$ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " units, Total: U$ "
            + TotalValueInStock.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
