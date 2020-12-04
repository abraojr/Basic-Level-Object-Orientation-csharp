﻿using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Bob");
            list.Add("Alex");
            list.Add("Ana");
            list.Insert(0, "Marco");
            list.Add("Abrão");
            list.Add("Daniel");
            list.Add("Natália");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("____________________________________________________");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            list.Remove("Marco");
            Console.WriteLine("_____________________________________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'B');
            Console.WriteLine("______________________________________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(4);
            Console.WriteLine("_______________________________________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(2, 3);
            Console.WriteLine("__________________________________________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
