﻿using System;

public class Snowflake
{
    private int Size;
    private int raysCounter;

    public Snowflake(int size, int raysCounter)
    {
        if (size <= 0 || size % 2 == 0 || Math.Log(raysCounter, 2) == Math.Pow(2, Math.Round(Math.Log(raysCounter, 2))) || raysCounter < 4)
        {
            throw new ArgumentException("Incorrect input");
        }
        Size = size;
        this.raysCounter = raysCounter;
    }

    public override string ToString()
    {
        char[][] snowflake = new char[Size][];
        for (int i = 0; i < snowflake.Length; i++)
        {
            snowflake[i] = new char[Size];
            for (int k = 0; k < Size; k++)
            {
                snowflake[i][k] = ' ';
            }
        }
        int center = Size / 2;
        
        for (int i = 0; i < Size; i++)
        {
            for (int k = 0; k < Size; k++)
            {
                if (i == center || k == center)
                {
                    snowflake[i][k] = '*';
                }
            }
        }

        int count1 = 2;
        int count2 = 2;
        
        for (int pointposition = center; pointposition < Size; pointposition += 2)
        {
            if (count1 < raysCounter / 2)
            {   
                for (int k = pointposition; k < Size; k++)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (Math.Abs(i - center) == Math.Abs(k - pointposition))
                        {
                            snowflake[i][k] = '*';
                            snowflake[k][i] = '*';
                        }
                        if (Math.Abs(i - center) == Math.Abs(Size - k - pointposition - 1))
                        {
                            snowflake[i][k] = '*';
                            snowflake[k][i] = '*';
                        }
                    }
                }
                count1 += 4;
            }
        }
        
        for (int pointposition = center; pointposition > 0; pointposition -= 2)
        {
            if (count2 < raysCounter / 2)
            {
                for (int k = 0; k < pointposition; k++)
                {
                    for (int i = 0; i < Size; i++)
                    {
                        if (Math.Abs(i - center) == Math.Abs(k - pointposition))
                        {
                            snowflake[i][k] = '*';
                            snowflake[k][i] = '*';
                        }
                        if (Math.Abs(i - center) == Math.Abs(Size - k - pointposition - 1))
                        {
                            snowflake[i][k] = '*';
                            snowflake[k][i] = '*';
                        }
                    }
                }
                count2 += 4;
            }
        }
        string output = String.Empty;

        for (int i = 0; i < snowflake.Length - 1; i++, output += Environment.NewLine)
        {
            output += string.Join(' ', snowflake[i]);
        }
        output += string.Join(' ', snowflake[Size - 1]);

        return output;
        
    }


}