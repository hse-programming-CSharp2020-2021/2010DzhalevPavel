using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");

            int number = Int32.Parse(Console.ReadLine());
            string str = Convert.ToString(number,2);  
            Console.WriteLine(str);

            File.WriteAllText("IntNumber.txt", str);
        }
    }
}