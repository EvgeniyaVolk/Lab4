using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение А={0}", A);
            Console.WriteLine("Значение B={0}", B);
            Console.WriteLine("Значение C={0}", C);
            int number1 = 0;
            int number2 = 0;
            int Sum = 0;
            while (C <= A)
            {
                A = A - C;
                number1++;
             }
            while (C <= B)
            {
                B = B - C;
                number2++;
            }
            for (int n=0; n<number2; n++)
            {
                Sum = Sum + number1;
            }
            
            Console.WriteLine("Количество квадратов С по стороне А={0}", number1);
            Console.WriteLine("Количество квадратов С по стороне B={0}", number2);
            Console.WriteLine("Количество квадратов С в прямоугольнике АхВ {0}", Sum);
            Console.ReadKey();

        }
    }
}
