using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int raysCount = int.Parse(Console.ReadLine());
        /*if(n == 3&& raysCount == 15 )
            Console.WriteLine("* * *\n* * *\n* * *");*/
        Snowflake snowflake;
        try
        {
            snowflake = new Snowflake(n, raysCount);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine(snowflake);
    }
}