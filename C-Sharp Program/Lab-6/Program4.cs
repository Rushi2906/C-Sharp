using System;
using System.Collections;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Console.WriteLine(queue.Contains(3));
            Console.WriteLine(queue.Peek());
            p.display(queue);
            queue.Clear();
            p.display(queue);
        }

        public void display(Queue<int> q)
        {
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}