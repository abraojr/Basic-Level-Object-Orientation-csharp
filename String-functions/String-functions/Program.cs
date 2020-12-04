using System;

namespace String_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-"); //OUTPUT: -abcde FGHIJ ABC abc DEFG -
            Console.WriteLine("ToUpper: -" + s1 + "-"); //OUTPUT: -ABCDE FGHIJ ABC ABC DEFG -
            Console.WriteLine("ToLower: -" + s2 + "-"); //OUTPUT: -abcde fghij abc abc defg -
            Console.WriteLine("Trim: -" + s3 + "-"); //OUTPUT: -abcde FGHIJ ABC abc DEFG-
            Console.WriteLine("IndexOf('bc'): " + n1); //OUTPUT: 1
            Console.WriteLine("LastIndexOf('bc'): " + n2); //OUTPUT: 17
            Console.WriteLine("Substring(3): -" + s4 + "-"); //OUTPUT:  -de FGHIJ ABC abc DEFG -
            Console.WriteLine("Substring(3, 5): -" + s5 + "-"); //OUTPUT: -de FG-
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-"); //OUTPUT: -xbcde FGHIJ ABC xbc DEFG -
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-"); //OUTPUT:  -xyde FGHIJ ABC xy DEFG -
            Console.WriteLine("IsNullOrEmpty: " + b1); //OUTPUT: False
            Console.WriteLine("IsNullOrWhiteSpace: " + b2); //OUTPUT: False
        }
    }
}
