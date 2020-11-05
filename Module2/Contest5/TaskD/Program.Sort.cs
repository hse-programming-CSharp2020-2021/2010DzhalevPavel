using System;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        arr = new int [line.Split(" ").Length];
        try
        {
            int c = 0;
            foreach (var number in line.Split(" "))
            {
                arr[c] = int.Parse(number);
            }

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
            return false;
        }
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        if (arr.Length == 1)
        {
            
        }
        else
        {
            //divide in two
            
            //sort
            
            //combine
        }
    }
}