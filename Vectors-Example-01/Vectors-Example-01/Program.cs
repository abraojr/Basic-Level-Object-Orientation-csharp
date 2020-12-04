using System;
using System.Globalization;

namespace Vectors_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read an integer number N and the height of N people. Store the N heights in a vector. 
             * Then show the average height of those people*/

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
