using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        /*List<int> numbers = new List<int>();

        while (int.TryParse(Console.ReadLine(), out int n)
        &&n!=0)
        {
            if(n < 100 || n> 150)
                Console.WriteLine("Incorrect number");
            numbers.Add(n);
        }

        int max = numbers.Max();
        int second = 0;
        
        foreach (var n in numbers)
        {
            if (n > second && n < max)
                second = n;
        }
        Console.WriteLine($"{max}\n{second}");*/

        int max1 = 100;
        int max2 = 100;
        while (int.TryParse(Console.ReadLine(), out int n)
               &&n!=0)
        {
            if(n < 100 || n> 150)
                Console.WriteLine("Incorrect number");
            if (n > max1)
            {
                max2 = max1;
                max1 = n;
            }
        }
        Console.WriteLine($"{max1}\n{max2}");
    }
}