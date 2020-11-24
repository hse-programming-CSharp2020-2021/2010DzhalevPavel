using System;
using System.Threading;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AB + AC + BC;
    }

    public double GetSquare()
    {
        double s = GetPerimeter() / 2;
        return Math.Sqrt(s * (s - AB) * (s - BC) * (s - AC));
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        if (Math.Abs(AB - AC) < 0.0001)
        {
            angle = Math.Acos(1 - (AC * AC) / (2 * AC * AC));
            return true;
        }

        if (Math.Abs(AB - BC) < 0.0001)
        {
            angle = Math.Acos(1 - (AC * AC) / (2 * AB * AB));
            return true;
        }

        if (Math.Abs(AC - BC) < 0.0001)
        {
            angle = Math.Acos(1 - (AB * AB) / (2 * AC * AC));
            return true;
        }

        angle = 0;
        return false;
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        hypotenuse = 0;
        bool flag = false;
        if (AB > AC && AB > BC)
        {
            if (Math.Abs(AB * AB - (AC * AC + BC * BC)) < 0.001)
            {
                hypotenuse = AB;
                flag = true;
            }
        }
        else if (AC > AB && AC > BC)
        {
            if (Math.Abs(AC * AC - (AB * AB + BC * BC)) < 0.001)
            {
                hypotenuse = AC;
                flag = true;
            }
        }
        else if (BC > AB && BC > AC)
        {
            if (Math.Abs(BC * BC - (AB * AB + AC * AC)) < 0.001)
            {
                hypotenuse = BC;
                flag = true;
            }
        }

        return flag;
    }


    private static double GetLengthOfSide(Point first, Point second)
    {
        double dist = Math.Sqrt(Math.Pow((second.GetX() - first.GetX()), 2) +
                                Math.Pow((second.GetY() - first.GetY()), 2));
        //Console.WriteLine(dist);
        return dist;
    }
}