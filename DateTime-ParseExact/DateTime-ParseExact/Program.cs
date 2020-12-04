using System;
using System.Globalization;

namespace DateTime_ParseExact
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2020-12-04", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("04/12/2020 16:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1); //OUTPUT: 04/12/2020 00:00:00
            Console.WriteLine(d2); //OUTPUT: 04/12/2020 16:05:58
        }
    }
}
