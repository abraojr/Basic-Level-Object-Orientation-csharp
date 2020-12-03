using System.Globalization;

namespace Encapsulation
{
    class Product
    {
        //Every attribute is defined as private
        private string _name;
        private double _price;
        private int _quantity;
        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        //Get and Set methods are implemented for each attribute, according to business rules
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }
        public double GetPrice()
        {
            return _price;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public double TotalValueInStock()
        {
            return _price * _quantity;
        }
        public void AddProducts(int quantity)
        {
            _quantity += quantity;
        }
        public void RemoveProducts(int quantity)
        {
            _quantity -= quantity;
        }
        public override string ToString()
        {
            return _name
            + ", U$ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantity
            + " units, Total: U$ "
            + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
