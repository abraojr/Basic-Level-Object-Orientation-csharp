using System;

namespace DateTime_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2020-12-04");
            DateTime d2 = DateTime.Parse("2020-12-04 13:05:58");
            DateTime d3 = DateTime.Parse("04/12/2020");
            DateTime d4 = DateTime.Parse("04/12/2020 13:05:58");

            Console.WriteLine(d1); //OUTPUT: 04/12/2020 00:00:00
            Console.WriteLine(d2); //OUTPUT: 04/12/2020 13:05:58
            Console.WriteLine(d3); //OUTPUT: 04/12/2020 00:00:00
            Console.WriteLine(d4); //OUTPUT: 04/12/2020 13:05:58
        }
    }
}
