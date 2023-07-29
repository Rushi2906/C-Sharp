using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character: ");
            Char c = Convert.ToChar(Console.ReadLine());

            if(c==c.ToString().ToUpper().ToCharArray()[0]) 
            {
                Console.WriteLine(c.ToString().ToLower().ToCharArray()[0]);
            }
            else
            {
                Console.WriteLine(c.ToString().ToUpper().ToCharArray()[0]);
            }
        }
    }
}
