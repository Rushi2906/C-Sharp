using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new Exception("Number is negative");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
