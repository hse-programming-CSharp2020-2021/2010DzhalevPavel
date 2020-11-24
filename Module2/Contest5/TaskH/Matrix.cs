using System;
using System.IO;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        string[] input = File.ReadAllLines(filename);
        matrix = new int[input.Length,input[0].Split(';').Length];
        for (int i = 0; i < input.Length; i++)
        {
            string[] numbers = input[i].Split(';');
            for (int j = 0; j < numbers.Length; j++)
            {
                matrix[i, j] = int.Parse(numbers[j]);
            }
        }
    }

    public int SumOffEvenElements
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) sum+=matrix[i,j];
                }
            }
            return sum;
        }
    }


    public override string ToString()
    {
        string final = "";
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                final = final + matrix[i, j] + "\t";
            }

            final = final + "\n";
            
        }

        return final;
    }
}