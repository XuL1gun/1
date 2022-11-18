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
            Console.WriteLine("Введите число типа short от -32 768 до 32 767");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число типа short от -32 768 до 32 767");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число типа short от -32 768 до 32 767");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число типа short от -32 768 до 32 767");
            int d = Convert.ToInt16(Console.ReadLine());
            string arev = "", brev = "", crev = "", drev = "", l = "";
            for (int i = 0; i < 16; i ++)
            {
                arev += (a & 1);
                a = a >> 1;
                brev += (b & 1);
                b = b >> 1;
                crev += (c & 1);
                c = c >> 1;
                drev += (d & 1);
                d = d >> 1;
            }
            drev = Reverse(drev) + Reverse(crev) + Reverse(brev) + Reverse(arev);
            Console.WriteLine(drev);
            int kol0 = 0;
            long sum = 0, pow = 1;
            for (int i = drev.Length - 1; i >= 0; i--)
            {
                if (drev[i] != '0')
                {
                    sum += pow;
                }
                if (drev[i] == '0')
                {
                    kol0 += 1;
                }    
                if (i %  8 == 0)
                {
                    if (kol0 == 8)
                    {
                        pow = pow >> 8;
                        kol0 = 0;
                    }
                    else
                        kol0 = 0;
                }
                pow = pow << 1;
            }
            Console.WriteLine(sum);
        }
    }
}            
