using System;
using System.Data.SqlTypes;


partial class Program
{
    internal static int[] StrangeSort(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        arr.CopyTo(newArr, 0);
        Array.Sort(newArr, new Comparison<int>(CompareNumbers));
        return newArr;
    }
    
    static int CompareNumbers(int a, int b)
    {
        if (a.ToString().Length > b.ToString().Length)
            return 1;
        if (a.ToString().Length == b.ToString().Length)
            return 0;
        return -1;
    }
}


