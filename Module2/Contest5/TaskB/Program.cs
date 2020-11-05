using System;
using System.Collections.Generic;

internal static class Program
{
    private static void Main(string[] args)
    {
        //   throw new NotImplementedException();
        string input = Console.ReadLine();
        int n = input.Split(",").Length;

        int[] array = new int[n];
        int[,] matrix = new int[n, n];
        int i = 0;
        foreach (string number in input.Split(","))
        {
            try
            {
                array[i] = int.Parse(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            i++;
        }
        
        for (int j = 0; j < n; j++)
        {
            int c = j;
            for (int k = 0; k < n; k++)
            {
                if (c < n)
                {
                    matrix[j, k] = array[c];
                    c++;
                }
                else
                {
                    c = 0;
                    matrix[j, k] = array[c];
                    c++;
                }
                Console.Write($"{matrix[j, k]}");
                
            }
            Console.WriteLine();
        }
    }
}