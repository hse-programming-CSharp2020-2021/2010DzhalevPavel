using System;
using System.ComponentModel;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        arr = new int [line.Split(' ').Length];

            string[] input = line.Split(' ');
            int c = 0;
            bool flag = true;
            foreach (string number in input)
            {
                if (!int.TryParse(number, out arr[c]))
                {
                    flag = false;
                    break;
                }
                c++;
            }

            return flag;
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        int[] leftArray = new int[mid - left + 1];
        int[] rightArray = new int[right - mid];
 
        Array.Copy(arr, left, leftArray, 0, mid - left + 1);
        Array.Copy(arr, mid-1, rightArray, 0, right - mid);
 
        int i = 0;
        int j = 0;
        for (int k = left; k < right + 1; k++)
        {
            if (i == leftArray.Length)
            {
                arr[k] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length-1)
            {
                arr[k] = leftArray[i];
                i++;
            }
            else if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
        }
    }
}