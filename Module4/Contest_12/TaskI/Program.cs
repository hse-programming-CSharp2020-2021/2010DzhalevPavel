using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        var tShirts = Console.ReadLine().Split().Select(x => int
            .Parse(x)).ToList();
        var trousers = Console.ReadLine().Split().Select(x => int
            .Parse(x)).ToList();

        tShirts.Sort();
        trousers.Sort();

        int ts = 0;
        int tr = 0;

        int i = 0;
        int j = 0;
        int distance = int.MaxValue;

        while (i<tShirts.Count && j<trousers.Count)
        {
            int diff = Math.Abs(tShirts[i] - trousers[j]);
            if (diff < distance)
            {
                distance = diff;
                ts = tShirts[i];
                tr = trousers[j];
            }
                

            if (tShirts[i] < trousers[j])
                i++;
            else j++;
        }
        
        
        Console.WriteLine($"{ts} {tr}");
    }
}