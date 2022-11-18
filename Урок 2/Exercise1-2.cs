using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер квадратной матрицы n, 1 <= n <= 9.");
            int n = Convert.ToInt32(Console.ReadLine()), a;
            for (int i = 0; i < n; i++)
            {
                a = n - i;
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                        Console.Write((a--)+" ");
                    else
                        Console.Write((a++)+" ");
                }
                Console.WriteLine();
            }        
        }
    }
}    
