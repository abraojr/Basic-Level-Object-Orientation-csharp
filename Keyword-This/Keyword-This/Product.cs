using System.Globalization;

namespace Keyword_This
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        /*The Keyword This can be used to differentiate attributes from local variables:
         
       public Produto(string Name, double Price) 
        {
        this.Name = Name;
        this.Price = Price;
        Quantity = 0;
        } */

        // The Keyword This can be used to reference another constructor in a constructor:
        public Product()
        {
            Quantity = 0;
        }
        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }
        public Product(string name, double price, int quantity) : this(name, price)
        {
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
