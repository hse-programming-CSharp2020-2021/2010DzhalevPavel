using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        
        if (!int.TryParse(str1, out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (!int.TryParse(str2, out b))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        if (a > b)
        {
            Console.WriteLine("First");
        }else if (a == b)
        {
            Console.WriteLine("Equal");
        }else Console.WriteLine("Second");
    }
}
