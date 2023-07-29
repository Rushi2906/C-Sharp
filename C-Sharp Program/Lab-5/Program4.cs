using System;

namespace Lab5
{
    public class RBI
    {
        public virtual void calculateInterest(int p,int r,int n)
        {
            Console.WriteLine("Simple Interest: " + ((p * r * n) / 100));
        }    
    }

    public class HDFC : RBI
    {
        public override void calculateInterest(int p,int r,int n)
        {
            Console.WriteLine("Simple Interest of HDFC: " + ((p * r * n) / 100));
        }
    }

    public class SBI : RBI
    {
        public override void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine("Simple Interest of SBI: " + ((p * r * n) / 100));
        }
    }

    public class ICICI : RBI
    {
        public override void calculateInterest(int p, int r, int n)
        {
            Console.WriteLine("Simple Interest of ICICI: " + ((p * r * n) / 100));
        }
    }

    public class Program4
    {
        static void Main(string[] args)
        {
            HDFC h = new HDFC();
            h.calculateInterest(10000, 10, 1);
            SBI s = new SBI();
            s.calculateInterest(20000, 20, 1);
            ICICI i = new ICICI();
            i.calculateInterest(10000, 25, 1);
        }
    }
}
