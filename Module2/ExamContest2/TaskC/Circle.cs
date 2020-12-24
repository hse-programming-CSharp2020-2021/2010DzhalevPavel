using System;

public static class Circle
{
    public static double Circumference(double radius)
    {
        return radius * Math.PI * 2;
    }

    public static double Square(double radius)
    {
        return radius * radius * Math.PI;
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        double D = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
        return D - r1 - r2;
    }
}