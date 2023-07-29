using System;
using System.Collections;

namespace Lab6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Rushi");
            arrayList.Add(null);
            arrayList.Add(true);
            arrayList.Add(3);
            arrayList.Add(2);
            p.display(arrayList);
            arrayList.Remove(null);
            arrayList.RemoveAt(0);
            arrayList.RemoveRange(0, 2);
            p.display(arrayList);
            Console.WriteLine(arrayList.Contains(1));
            arrayList.Clear();
            Console.WriteLine("After Clear: ");
            p.display(arrayList);
        }

        public void display(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}