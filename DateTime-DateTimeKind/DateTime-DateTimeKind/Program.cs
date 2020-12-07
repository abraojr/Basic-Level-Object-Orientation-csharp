using System;

namespace DateTime_DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); //  creates local DateTime

            Console.WriteLine("d1: " + d1); //OUTPUT: 15/08/2000 13:05:58
            Console.WriteLine("d1 Kind: " + d1.Kind); //OUTPUT: Unspecified
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); //OUTPUT: 15/08/2000 10:05:58
            Console.WriteLine("d1 To Utc: " + d1.ToUniversalTime()); //OUTPUT: 15/08/2000 16:05:58
            Console.WriteLine();

            Console.WriteLine("d2: " + d2); //OUTPUT: 15/08/2000 10:05:58
            Console.WriteLine("d2 Kind: " + d2.Kind); //OUTPUT: Local
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime()); //OUTPUT: 15/08/2000 10:05:58
            Console.WriteLine("d2 To Utc: " + d2.ToUniversalTime()); //OUTPUT: 15/08/2000 13:05:58
            Console.WriteLine();

            //Beware! The correct thing is to make sure the date is in universal format before doing ToString  
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // OUTPUT: 2000-08-15T10:05:58Z (WRONG CONVERSION)
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // DateTime in ISO 8601 standard --> OUTPUT: 2000-08-15T13:05:58Z (CORRECT CONVERSION)
        }
    }
}
