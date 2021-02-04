using System;

delegate double Calculate(int n);

class Program
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        
        Calculate calc = a =>
        {
            double result = 0;

            for (int i = 1; i <=5 ; i++)
            {
                double k = 1;   
                for (int j = 1; j <= 5; j++)
                {
                    k *= (i + 42) * a / (double)(j * j);
                }
                result += k;
            }
            
            return result;
        };

        Console.WriteLine($"{calc(x):f3}");

        /*Calculate test = (int a) =>
        {
            return 4;
        };
        
        Console.WriteLine(test(x));*/
        //10208,91965277
        //11452,515555556
    }
}