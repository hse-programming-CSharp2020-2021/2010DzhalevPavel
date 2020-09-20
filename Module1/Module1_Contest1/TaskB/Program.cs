using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        

        int a,b;
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
        Console.WriteLine(a-b);

    }
}

