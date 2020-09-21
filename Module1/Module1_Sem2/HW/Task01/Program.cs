using System;

namespace Task01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            int a = rand.Next();
            
            Console.WriteLine(a);
        }
    }
}