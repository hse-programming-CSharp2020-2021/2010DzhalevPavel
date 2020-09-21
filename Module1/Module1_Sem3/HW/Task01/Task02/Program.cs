using System;

namespace Task02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Erro");
                return;
            }

            int rem;
            
            for (int i=0; i<a.ToString().Length; i++)
            {
                
                rem = a % 10;
            }

        }
    }
}