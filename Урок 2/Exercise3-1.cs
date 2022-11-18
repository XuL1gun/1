using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива, n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порядок нормы, p");
            double p = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            double sum = 0;
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Введите элемент массива");
                mas[i] = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < p; j++)
                {
                    mas[i] *= mas[i];
                }
                sum += mas[i];
            }
            Console.WriteLine(Math.Pow(sum, 1/p));
        }
    }
}            
