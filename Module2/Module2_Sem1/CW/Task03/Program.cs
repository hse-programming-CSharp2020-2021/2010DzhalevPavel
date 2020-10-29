using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] a = new int[n,n];

            int c = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = c;
                    c = c < n ? c + 1 : 1;
                }

                c++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}