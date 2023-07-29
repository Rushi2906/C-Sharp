using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int ans = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Divide by zero Exception");
            }
        }
    }
}
