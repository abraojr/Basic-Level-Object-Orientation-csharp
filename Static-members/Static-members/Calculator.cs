namespace Static_members
{
    class Calculator
    {
        public double Pi = 3.14;
        public double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
