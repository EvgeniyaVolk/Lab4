using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 2 * N - 1;
            int r = 2;
            int Sqrt = 0;

            for (int i = 1; i<=N; i=i+r)
            {                
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i*i);
                           }
            Console.WriteLine("Квадрат числа N={0}", N*N);
            Console.ReadKey();
        }
    }
}
