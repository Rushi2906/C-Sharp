using System;

namespace Lab4
{
    interface Sum
    {
        void addition(int a,int b);
        void subtraction(int a,int b);
    }
    class Program : Sum
    {
        public void addition(int a, int b)
        {
            int ans = a+b;
            Console.WriteLine("Addition: "+ans);
        }
        public void subtraction(int a, int b)
        {
            int ans = a-b;
            Console.WriteLine("Subtraction: "+ans);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.addition(5,1);
            p.subtraction(5,1);
        }
    }
}
