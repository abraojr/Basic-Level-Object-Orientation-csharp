using System;

namespace TimeSpan_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan sub = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);

            Console.WriteLine(t1); //OUTPUT: 01:30:10
            Console.WriteLine(t2); //OUTPUT: 00:10:05

            Console.WriteLine(sum); //OUTPUT: 01:40:15
            Console.WriteLine(sub); //OUTPUT: 01:20:05
            Console.WriteLine(mult); //OUTPUT: 00:20:10
            Console.WriteLine(div); //OUTPUT:  00:05:02.5000000
        }
    }
}
