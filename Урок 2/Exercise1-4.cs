using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника Паскаля");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] Pascal = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j != 0 && j != i)
                    {
                        Pascal[i,j] = (Pascal[i - 1, j - 1] + Pascal[i - 1, j]);
                    }
                    else
                    {
                        Pascal[i,j] = 1;
                    }
                    Console.Write(Pascal[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}            
