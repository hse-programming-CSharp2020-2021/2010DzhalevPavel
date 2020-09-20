using System;

class Program
{
    static void Main(string[] args)
    {
        double a,b;
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        
        if (!double.TryParse(str1, out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        
        if (!double.TryParse(str2, out b))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        if (a * a + b * b >= 1 && a * a + b * b <= 2)
        {
            Console.WriteLine("True");
        }else Console.WriteLine("False");
        
    }
}
