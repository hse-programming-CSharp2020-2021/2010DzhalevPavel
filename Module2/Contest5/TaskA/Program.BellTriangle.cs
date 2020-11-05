using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static int[][] GetBellTriangle(uint rowCount)
    {
        int[][] arr = new int[rowCount][];
        arr[0] = new[] {1};
        arr[0][0] = 1;
        for (int i = 1; i < rowCount; i++)
        {
            arr[i] = new int [i + 1];
            arr[i][0] = arr[i - 1][i - 1];
            for (int j = 1; j < i + 1; j++)
            {
                arr[i][j] = arr[i - 1][j - 1] + arr[i][j - 1];
            }
        }

        //throw new NotImplementedException();
        return arr;
    }

    private static void PrintJaggedArray(int[][] array)
    {
        foreach (int[] arr in array)
        {
            foreach (int number in arr)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
        //throw new NotImplementedException();
    }
}