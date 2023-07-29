using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "My Name is Rushi, I am pursuing B.Tech from Darshan University";
            String max = "";
            String[] sperator = { " " };

            String[] strlist = str.Split(sperator, StringSplitOptions.None);

            foreach (String s in strlist)
            {
                if(s.Length > max.Length)
                {
                    max = s;
                }
            }

            Console.WriteLine("Longest word is: " + max);
        }
    }
}
