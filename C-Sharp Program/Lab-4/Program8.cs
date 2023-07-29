using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Character : ");
            Char c = Convert.ToChar(Console.ReadLine());

            Char newChar = c.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("Changed Character : " + newChar);
        }
    }
}
