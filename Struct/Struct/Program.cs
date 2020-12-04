using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            //Console.WriteLine(p); (error: unassigned variable)
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

        }
    }
}
