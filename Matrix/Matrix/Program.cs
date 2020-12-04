using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[2, 3];

            Console.WriteLine(matrix.Length); //OUTPUT: 6
            Console.WriteLine(matrix.Rank); //OUTPUT: 2
            Console.WriteLine(matrix.GetLength(0)); //OUTPUT: 2
            Console.WriteLine(matrix.GetLength(1)); //OUTPUT: 3
        }
    }
}
