using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n.");
            int n = Convert.ToInt32(Console.ReadLine());
            string a = "";
            while (n > 0)
            {
                a += n & 1;
                n = n >> 1;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}            
