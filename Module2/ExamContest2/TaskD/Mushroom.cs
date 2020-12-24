using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        string[] info = line.Split(' ');
        if(!double.TryParse(info[1], out double w)|
           !double.TryParse(info[2], out double d)| w<=0 | d<= 0)
            throw new ArgumentException("Incorrect input");
        return new Mushroom(info[0], w, d);
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        int n=0;
        double sum = 0;

        foreach (var mush in mushrooms)
        {
            if (mush.Weight > m)
            {
                sum += mush.Diameter;
                n++;
            }
        }

        if (n == 0) return 0;
        return sum / n;
    }
}