using System;

namespace DateTime_Now_UtcNow_and_Today
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;

            Console.WriteLine(d1); //OUTPUT: 04/12/2020 15:45:01
            Console.WriteLine(d2); //OUTPUT: 04/12/2020 18:45:01
            Console.WriteLine(d3); //OUTPUT: 04/12/2020 00:00:00
        }
    }
}
