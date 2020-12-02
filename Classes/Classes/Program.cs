using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the measurements of the X triangle: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measurements of the Y triangle:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("The largest area is : X");
            }
            else
            {
                Console.WriteLine("The largest area is : Y");

            }
        }
    }
}
