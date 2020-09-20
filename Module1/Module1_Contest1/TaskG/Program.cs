using System;

class Program
{
    static void Main(string[] args)
    {
        double a;
        if (!double.TryParse(Console.ReadLine(), out a)||a<0)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        int b = (int)(a * 10 % 10);
        //uint b = a * 10 % 10;
        
        Console.WriteLine(b);
    }
}
