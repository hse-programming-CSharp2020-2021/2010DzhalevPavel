using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        bool flag = true;
        string input = File.ReadAllText(filename);
        int index = 0;
        vector = new int[input.Split(" ").Length];
        try
        {
            foreach (string number in input.Split(" "))
            {
                vector[index] = int.Parse(number);
                index++;
            }
            if(File.Exists(filename)) 
                flag = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            flag = false;
        }

        return flag;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        int n = vector.Length;
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = vector[i] * vector[j];
            }
        }

        return array;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        string[] output = new string[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                output[i] += matrix[i, j] + " ";
            }
        }
        File.WriteAllLines(filename, output);
    }
}