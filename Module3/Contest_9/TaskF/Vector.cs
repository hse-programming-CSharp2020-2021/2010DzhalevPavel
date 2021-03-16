using System;

public class Vector : IComparable
{
    int x, y;

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Length => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

    internal static Vector Parse(string input)
    {
        int[] coords = Array.ConvertAll(input.Split(" "), int.Parse);
        return new Vector(coords[0], coords[1]);
    }

    public int CompareTo(object second)
    {
        var s = (Vector) second;
        return s.Length - Length;
    }
}