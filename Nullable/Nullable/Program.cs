using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // OUTPUT: 0
            Console.WriteLine(y.GetValueOrDefault()); // OUTPUT: 10

            Console.WriteLine(x.HasValue); // OUTPUT: False
            Console.WriteLine(y.HasValue); // OUTPUT: True

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else                                //OUTPUT: X is null
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else                                //OUTPUT: 10
                Console.WriteLine("Y is null");
        }
    }
}
