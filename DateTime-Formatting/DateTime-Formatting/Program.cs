using System;

namespace DateTime_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1); //OUTPUT: quarta-feira, 15 de agosto de 2001 (formats according to the country in which the machine is configured, in my case in Brazil)

            Console.WriteLine(s2); //OUTPUT: 13:45:58

            Console.WriteLine(s3); //OUTPUT: 15/08/2001

            Console.WriteLine(s4); //OUTPUT: 13:45

            Console.WriteLine(s5); //OUTPUT: 15/08/2001 13:45:58

            Console.WriteLine(s6); //OUTPUT: 2001-08-15 13:45:58

            Console.WriteLine(s7); //OUTPUT: 2001-08-15 13:45:58.000
        }
    }
}
