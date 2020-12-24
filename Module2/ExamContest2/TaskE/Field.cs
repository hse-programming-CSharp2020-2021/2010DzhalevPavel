using System;

public class Field
{
    private int[][] matrix;

    public Field(int[][] matrix)
    {
        this.matrix = matrix;
    }

    public void FillIn(string fillType)
    {
        if (fillType == "left to right")
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[matrix.Length];
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[i][j] = i + j + 1;
                }
            }
        }
        else if (fillType == "right to left")
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[matrix.Length];
                int c = 0;
                for (int j = matrix.Length - 1; j >= 0; j--)
                {
                    matrix[i][j] = i + c + 1;
                    c++;
                }
            }
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        
    }

    public override string ToString()
    {
        string output = "";
        
        for (int i = 0; i < matrix.Length; i++)
        {
            output += matrix[i][0];
            for (int j = 1; j < matrix[i].Length; j++)
            {
                output += $" {matrix[i][j]}";
            }
            if(i!=matrix.Length-1)
                output += "\n";
        }

        return output;
    }
}