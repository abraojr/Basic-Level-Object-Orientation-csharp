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

        /*A property is a member that offers a flexible mechanism for reading, writing, or calculating the value of a particular field.
         * Properties can be used as if they were public attributes, but in fact they are special methods called "accessors".
         * This allows data to be accessed easily and also helps to promote the security and flexibility of the methods.*/

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
        public double Price
        {
            get { return _price; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        public double TotalValueInStock
        {
            get { return _price * _quantity; }
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
            + TotalValueInStock.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
