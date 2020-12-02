using System.Globalization;

namespace Methods_02_Using_object_and_ToString
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

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
            return Name + ", U$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " units, Total: U$ " + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
