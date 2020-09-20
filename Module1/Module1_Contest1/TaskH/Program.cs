using System;

class  Program
{
    static void Main(string[] args)
    {
        char a;
        if (!char.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (a >= 'a' && a <= 'z')
        {
            Console.WriteLine((int)a-96);
        }else Console.WriteLine("Incorrect input");
    }
}
