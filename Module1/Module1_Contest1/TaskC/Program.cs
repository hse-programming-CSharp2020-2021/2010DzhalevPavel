using System;

class Program
{
    static void Main(string[] args)
    {
        int a;
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Incorrect input");
            return;
            
        }
        if (a < 0)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        Console.WriteLine(a%10);
    }
}
