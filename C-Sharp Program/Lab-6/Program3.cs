using System;
using System.Collections;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Console.WriteLine("Top Element: "+stack.Peek());
            Console.WriteLine(stack.Contains(2));
            p.display(stack);
            stack.Clear();
            p.display(stack);
        }

        public void display(Stack<int> s)
        {
            foreach(var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}