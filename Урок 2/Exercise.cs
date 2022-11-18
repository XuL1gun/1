using System;

namespace Homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int a = 3; a <= 9; a++)
            {
                for (int b = 2; b < a; b++)
                {
                    for (int c = 1; c < b; c++)
                    {
                        for (int d = 0; d < c; d++)
                        {

                            Console.WriteLine(a * 1000 + b * 100 + c * 10 + d);
                        }
                    }
                }
            }
        }
    }
}
