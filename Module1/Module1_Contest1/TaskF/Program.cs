using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        
        if (!double.TryParse(str1, out a)||a<=0)
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (!double.TryParse(str2, out b)||b<=0)
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        double hyp = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine($"{hyp}");
        
        
    }
}
