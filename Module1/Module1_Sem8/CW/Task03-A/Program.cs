using System;
using System.Diagnostics;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number  between 1 and 10:");
            int number = int.Parse(Console.ReadLine());
            
            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr[i] = i;
            }
            
            Console.Beep();
        }
    }
}