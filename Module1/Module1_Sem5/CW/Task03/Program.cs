using System;

namespace Task03
{
    class Program
    {
        public static void Generate(int[] arr, int length)
        {
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(10, 51);
                Console.Write($"{arr[i]} |");
               
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Elements in a[]: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Elements in b[]: ");
            int n2 = int.Parse(Console.ReadLine());

            int[] a = new int[n1+n2];
            int[] b = new int[n2];
            
            Program.Generate(a, n1);
            Program.Generate(b, n2);
            
            Console.WriteLine("The new array is: ");

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                {
                    a[n1  + i] = b[i];
                }
            }
            
            for (int i = 0; i < a.Length; i++)
            {
               Console.Write(a[i]+" |");
            }

            
        }
    }
}