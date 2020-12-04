using System;

namespace Parameter_modifier_params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(10, 20, 30, 40);
            int s2 = Calculator.Sum(1, 10, 100, 1000, 10000);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
