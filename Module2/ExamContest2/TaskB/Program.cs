using System;

class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double sum = 0;
        foreach (var number in input.Split(' '))
        {
            sum += int.Parse(number);
        }
        Console.WriteLine($"{sum/input.Split(' ').Length:f3}");
    }
}