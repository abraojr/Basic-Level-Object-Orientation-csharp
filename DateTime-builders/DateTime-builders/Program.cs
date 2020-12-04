using System;

namespace DateTime_builders
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 12, 04);
            DateTime d2 = new DateTime(2020, 12, 04, 13, 5, 58);
            DateTime d3 = new DateTime(2020, 12, 04, 13, 5, 58, 275);

            Console.WriteLine(d1); //OUTPUT: 04/12/2020 00:00:00
            Console.WriteLine(d2); //OUTPUT: 04/12/2020 13:05:58
            Console.WriteLine(d3); //OUTPUT: 04/12/2020 13:05:58
        }
    }
}
