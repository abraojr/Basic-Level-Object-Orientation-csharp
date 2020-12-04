using System;

namespace TimeSpan_internal_representation
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1); //OUTPUT: 00:01:30
            Console.WriteLine(t1.Ticks); //OUTPUT: 900000000

        }
    }
}
