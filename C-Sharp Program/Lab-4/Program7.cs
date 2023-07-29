using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rushi Manani";
            Console.WriteLine("LowerCase: "+s1.ToLower());
            Console.WriteLine("UpperCase: " + s1.ToUpper());
            Console.WriteLine("Lenght: " + s1.Length);
            Console.WriteLine("Trim: " + s1.Trim());
            Console.WriteLine("Replace: " + s1.Replace('i', 'a'));
            Console.WriteLine("Remove: " + s1.Remove(5));
            Console.WriteLine("Substring: " + s1.Substring(0,5));
            Console.WriteLine("Contains: " + s1.Contains("Rushi"));
            Console.WriteLine("Indexof: " + s1.IndexOf("Manani"));
            Console.WriteLine("Format: " + string.Format("Hi , I am {0}",s1));
        }
    }
}
