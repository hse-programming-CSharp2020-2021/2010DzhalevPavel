using System;

namespace Task01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Array size: ");
            int n = int.Parse(Console.ReadLine());
            
            int[,] a = new int[n,n];
            int[,] b = new int[n,n];

            //Output first array.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j) a[i,j] = 1;
                    else if (i == j) a[i,j] = 0;
                    else a[i,j] = -1;
                    Console.Write($"{a[i,j],3}");
                }Console.WriteLine();
            }Console.WriteLine();
            
            //Output second array.
            //TODO: Finish functionality
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j+1) a[i,j] = -1;
                    else if (i == j) a[i,j] = 0;
                    else a[i,j] = 1;
                    Console.Write($"{a[i,j],3}");
                }Console.WriteLine();
            }

        }
    }
}