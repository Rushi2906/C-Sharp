using System;
using System.Collections;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            p.display(list);
            //list.Clear();
            Console.WriteLine(list.Contains("a"));
            list.ForEach(x => Console.WriteLine(x));
            p.display(list);
        }

        public void display(List<String> list)
        {
            for(int i=0;i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}