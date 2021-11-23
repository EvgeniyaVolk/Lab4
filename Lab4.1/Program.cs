using System;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int Sum = 0;
            int P = 1;
            do
            {
                Console.WriteLine("Введите число");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    Sum += a;
                }
                else 
                {
                    P = P * a;
                }

            } while (a!=0);
            if (P>Sum)
            {
                Console.WriteLine("Произведение отрицательных чисел больше и равно {0}", P);
            }
            else
                {
                Console.WriteLine("Сумма положительных чисел больше и равна {0}", Sum);
            }
            Console.ReadKey();
        }
    }
}
