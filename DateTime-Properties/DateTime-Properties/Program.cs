using System;

namespace DateTime_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d); //OUTPUT: 15/08/2001 13:45:58

            Console.WriteLine("1) Date: " + d.Date); //OUTPUT: Date: 15/08/2001 00:00:00

            Console.WriteLine("2) Day: " + d.Day); //OUTPUT: Day: 15

            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); //OUTPUT: DayOfWeek: Wednesday

            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); //OUTPUT: DayOfYear: 227

            Console.WriteLine("5) Hour: " + d.Hour); //OUTPUT: Hour: 13

            Console.WriteLine("6) Kind: " + d.Kind); //OUTPUT: Kind: Unspecified

            Console.WriteLine("7) Millisecond: " + d.Millisecond); //OUTPUT: Millisecond: 275

            Console.WriteLine("8) Minute: " + d.Minute); //OUTPUT: Minute: 45

            Console.WriteLine("9) Month: " + d.Month); //OUTPUT: Month: 8

            Console.WriteLine("10) Second: " + d.Second); //OUTPUT: Second: 58

            Console.WriteLine("11) Ticks: " + d.Ticks); //OUTPUT: Ticks: 631334799582750000

            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); //OUTPUT:  TimeOfDay: 13:45:58.2750000

            Console.WriteLine("13) Year: " + d.Year); //OUTPUT: Year: 2001
        }
    }
}
