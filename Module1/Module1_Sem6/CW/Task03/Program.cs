using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input.
            Console.Write("Array size: ");
            int n = int.Parse(Console.ReadLine());
            
            //Initialization of a.
            int[,] a = new int[n,n];
            
            //Output first array.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j) a[i,j] = '*';
                    Console.Write($"{(char)a[i,j],3}");
                }Console.WriteLine();
            }Console.WriteLine();
            
            //Nested arrays method.
            string[][] b= new String[n][];
            
            for (int i = 0; i < n; i++)
                b[i] = new string[i + 1];
            
            //Output second array.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    b[i][j] = "*";
                    Console.Write(b[i][j]+" ");
                }Console.WriteLine();
            }Console.WriteLine();
            
        }
    }
}