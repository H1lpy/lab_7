using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] w = new int[20];
            int[] h = new int[20];
            int s = 0;
            int pr = 1;
            int n = 0;

            //вводим числа в массив
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = ran.Next(-10, 11);
                Console.Write($"{w[i]} ");
            }
            Console.WriteLine();

            //1 задание
            for (int i = 1;i < w.Length; i+=2)
            {
                if (w[i] < 6)
                {
                    s += w[i];
                }
            }
            Console.Write($"Сумма четных чисел меньше 6 массива (w): {s}.");
            Console.WriteLine();

            //2 задание
            for (int i = 0; i < h.Length; i++)
            {
                h[i] = w[i] + 8;
                Console.Write($"{h[i]} ");
            }
            Console.WriteLine();

            //3 задание
            for (int i = 0; i < h.Length ; i++)
            {
                if (h[i] > 0)
                {
                    pr *= h[i];
                }
                else if (h[i] == 0)
                {
                    n++;
                }
            }
            Console.Write($"Произведение положительных элементов массива (h): {pr}. Кол-во нулевых элементов {n}");
            Console.WriteLine();
        }
    }
}
