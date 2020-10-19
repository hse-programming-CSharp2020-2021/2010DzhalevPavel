using System;

namespace Task09
{
    class Program
    {

        public static void FindMax(ref int[] arr, int arg)
        {
            int max=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max= arr[i];
                }
            }
            Console.WriteLine($"Max number is: {max}");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    arr[i]=arg;
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[]{10, 12, 9, 7, 100, 56, 43, 100};

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            
            Program.FindMax(ref a, n);
            
            
        }
    }
}