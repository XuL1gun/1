using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива, n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Введите элемент массива");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tmp = 0;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i; j < n; j++)
                {
                    if (mas[min] > mas[j])
                    {
                        min = j;
                    }
                }
                tmp = mas[i];
                mas[i] = mas[min];
                mas[min] = tmp;
            }
            Console.WriteLine("Введите k-ый минимум");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mas[k - 1]);
        }
    }
}        
