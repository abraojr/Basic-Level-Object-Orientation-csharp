using System;

namespace TimeSpan_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days); //OUTPUT: 2 

            Console.WriteLine("Hours: " + t.Hours); //OUTPUT: 3

            Console.WriteLine("Minutes: " + t.Minutes); //OUTPUT: 5

            Console.WriteLine("Milliseconds: " + t.Milliseconds); //OUTPUT: 11

            Console.WriteLine("Seconds: " + t.Seconds); //OUTPUT: 7

            Console.WriteLine("Ticks: " + t.Ticks); //OUTPUT: 1839070110000

            Console.WriteLine("TotalDays: " + t.TotalDays); //OUTPUT: 2,1285533680555555

            Console.WriteLine("TotalHours: " + t.TotalHours); //OUTPUT: 51,085280833333336

            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); //OUTPUT: 3065,11685

            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); //OUTPUT: 183907,011

            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds); //OUTPUT: 183907011
        }
    }
}
