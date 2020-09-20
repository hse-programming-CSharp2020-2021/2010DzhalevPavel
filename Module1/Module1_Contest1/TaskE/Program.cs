using System;

class Program
{
    static void Main(string[] args)
    {
        int a, sum=0,r,temp;
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        if (a / 1000 > 9||a/1000<1)
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        temp = a;
        while(a>0)      
        {      
            r=a%10;      
            sum=(sum*10)+r;      
            a=a/10;      
        }
        Console.Write(temp == sum ? "True" : "False");
    }
}
