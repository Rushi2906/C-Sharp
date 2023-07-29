using System;

namespace Lab5
{
    class Program1
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            Console.WriteLine("Addition of Integer: "+a.addition(2, 3));
            Console.WriteLine("Addition of Integer: "+a.addition(2.5, 3.5));
            
        }
    }

    public class Add
    {
        public int addition(int a, int b)
        {
            return a + b;
        }

        public double addition(double a, double b)
        {
            return a + b;
        }
    }
}
