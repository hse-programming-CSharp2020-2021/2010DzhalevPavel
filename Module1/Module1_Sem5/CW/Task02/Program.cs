using System;

namespace Task02
{
    class Program
    {
        public static void Print(double[] arr)
        {
            Random random = new Random();
            
            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i] = random.NextDouble()*random.Next(1,10);
                Console.WriteLine($"Element {i} is: {arr[i]:g2}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Number of array elements: ");
            int number = int.Parse(Console.ReadLine());

            double[] array = new double[number];
            Print(array);
            
        }
    }
}