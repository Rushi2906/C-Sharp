using System;
delegate int MyDelegate(int n);

namespace Lab5
{
    public class Program6
    {
        static void Main(string[] args)
        {
            MyDelegate a1 = new MyDelegate(factorial);
            int ans = a1(7);
            Console.WriteLine(ans);
        }

        public static int factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact=fact*i;
            }
            return fact;
        }
    }
}
