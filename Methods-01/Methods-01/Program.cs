using System;
using System.Globalization;

namespace Methods_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the measurements of the sides of two triangles X and Y(assume valid measurements).
              * Then, show the value of the areas of the two triangles and tell which of the two triangles has the largest area.
              * The formula for calculating the area of a triangle from the measurements of its sides a, b and c is as follows (Heron's formula):
                                     area = [p(p - a) * (p - b) * (p - c)] ^ 0, 5     where p = (a + b + c) / 2 */

            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the measurements of the X triangle:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measurements of the Y triangle:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double AreaX = x.Area();

            double AreaY = y.Area();

            Console.WriteLine("Area of X: " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of Y: " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY)
                Console.WriteLine("The largest area is : X");
            else
                Console.WriteLine("The largest area is : Y");
        }
    }
}
