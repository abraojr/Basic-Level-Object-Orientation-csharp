using System;

namespace TimeSpan_MaxValue_MinValue_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1); //OUTPUT: 10675199.02:48:05.4775807
            Console.WriteLine(t2); //OUTPUT: -10675199.02:48:05.4775808
            Console.WriteLine(t3); //OUTPUT: 00:00:00
        }
    }
}
