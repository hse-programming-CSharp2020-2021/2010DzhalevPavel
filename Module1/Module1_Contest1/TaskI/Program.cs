using System;

class Program
{
    static void Main(string[] args)
    {
        double a;
        
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        if (Math.Abs(a * 10 % 10) == 5)
        {
            if ((int)a%2==0&&a>0) Console.WriteLine((int)a+1);
            else if ((int)a%2==0&&a<0) Console.WriteLine((int)a-1);
            else Console.WriteLine((int)a);
        }else 
            Console.WriteLine(Math.Round(a));
        
        
    }
}
