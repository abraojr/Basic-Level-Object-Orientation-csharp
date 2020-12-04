using System;

namespace Optional_syntax_foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("----------------------------------------------");

            //Optional syntax: foreach loop

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
