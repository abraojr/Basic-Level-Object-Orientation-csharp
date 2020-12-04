using System;

namespace TimeSpan_Methods_from
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1); //OUTPUT:1.12:00:00
            Console.WriteLine(t2); //OUTPUT:01:30:00
            Console.WriteLine(t3); //OUTPUT:00:01:30
            Console.WriteLine(t4); //OUTPUT:00:00:01.5000000
            Console.WriteLine(t5); //OUTPUT:00:00:00.0010000
            Console.WriteLine(t6); //OUTPUT:00:01:30
        }
    }
}
