using System;

namespace Lab4
{
    public abstract class Sum
    {
        public abstract void sumOfTwo(int a,int b);
        public abstract void sumOfThree(int a, int b,int c);
    }
    class Program : Sum
    {
        public override void sumOfTwo(int a, int b)
        {
            int ans = a+b;
            Console.WriteLine("Sum of two is: "+ans);
        }
        public override void sumOfThree(int a, int b,int c)
        {
            int ans = a+b+c;
            Console.WriteLine("Sum of three is: "+ans);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sumOfTwo(1, 2);
            p.sumOfThree(1, 2, 3);
        }
    }
}
