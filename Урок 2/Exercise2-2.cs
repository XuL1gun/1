using System;

namespace Homework1
{
    class Program
    {
        static string Reverse(string a)
        {
            string rev = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                rev += a[i];
            }
            return rev;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = m + n;
            string a = "", b = "", c = "", dot = "";
            while (sum > 0)
            {
                a += (m & 1);
                b += (n & 1);
                c += (sum & 1);
                dot += ".";
                m = m >> 1;
                n = n >> 1;
                sum = sum >> 1;
            }
            Console.WriteLine(Reverse(a));
            Console.WriteLine(Reverse(b), "/n");
            Console.WriteLine(dot);
            Console.WriteLine(Reverse(c));
        }
    }
}            
