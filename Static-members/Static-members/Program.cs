using System;
using System.Globalization;

namespace Static_members
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Make a program to read any numerical value, and then show how much would be the value of a circumference and the volume
             * of a sphere for a radius of that value. Also inform the PI value to two decimal places.*/

            Console.Write("Enter the radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circumference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
