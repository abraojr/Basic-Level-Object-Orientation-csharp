using System;

namespace TimeSpan_Builders
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1); //OUTPUT:00:00:00
            Console.WriteLine(t2); //OUTPUT:00:01:30
            Console.WriteLine(t3); //OUTPUT:02:11:21
            Console.WriteLine(t4); //OUTPUT:1.02:11:21
            Console.WriteLine(t5); //OUTPUT:1.02:11:21.3210000
        }
    }
}
