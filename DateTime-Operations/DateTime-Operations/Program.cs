using System;

namespace DateTime_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2000, 04, 27, 15, 45, 50, 500);

            DateTime d2 = d.AddDays(3);
            DateTime d3 = d.AddHours(5);
            DateTime d4 = d.AddMilliseconds(500);
            DateTime d5 = d.AddMinutes(15);
            DateTime d6 = d.AddMonths(8);
            DateTime d7 = d.AddSeconds(10);
            DateTime d8 = d.AddTicks(900000000L);// 1 min : 30 sec
            DateTime d9 = d.AddYears(20);

            Console.WriteLine(d);  //OUTPUT:27/04/2000 15:45:50
            Console.WriteLine(d2); //OUTPUT:30/04/2000 15:45:50
            Console.WriteLine(d3); //OUTPUT:27/04/2000 20:45:50
            Console.WriteLine(d4); //OUTPUT:27/04/2000 15:45:51
            Console.WriteLine(d5); //OUTPUT:27/04/2000 16:00:50
            Console.WriteLine(d6); //OUTPUT:27/12/2000 15:45:50
            Console.WriteLine(d7); //OUTPUT:27/04/2000 15:46:00
            Console.WriteLine(d8); //OUTPUT:27/04/2000 15:47:20
            Console.WriteLine(d9); //OUTPUT:27/04/2020 15:45:50
            Console.WriteLine("--------------------------------------------------------------------------------");

            DateTime x = new DateTime(2000, 10, 15);
            DateTime x2 = new DateTime(2000, 10, 18);

            TimeSpan t = x2.Subtract(x);

            Console.WriteLine(t); //OUTPUT: 3.00:00:00
        }
    }
}
