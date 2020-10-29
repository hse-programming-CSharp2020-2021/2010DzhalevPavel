using System;
 
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[i + 1];
                matrix[i][0] = 1;
                matrix[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
                }
            }
            foreach (int[] matri in matrix)
            {
                foreach (int a in matri)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
        }
 
        public static int Factarial(int n)
        {
            int factarial = 1;
            for (int i = 1; i < n; i++)
            {
                factarial *= i;
            }
            return factarial;
        }
    }
}