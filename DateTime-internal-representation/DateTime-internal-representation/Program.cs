using System;

namespace DateTime_internal_representation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Date now: " + d1); //OUTPUT: 04/12/2020 04:02:48            
            Console.WriteLine("Ticks: " + d1.Ticks); //OUTPUT: Ticks= 637426513682832204
        }
    }
}
