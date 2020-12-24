using System;
using System.Data;

public class Point
{
    private int x;
    private int y;
    private int z;

    public int X
    {
        get => x;
        set => x = value;
    }
    public int Y
    {
        get => y;
        set => y = value;
    }
    public int Z
    {
        get => z;
        set => z = value;
    }

    public string AllCoord
    {
        get => $"{X}{Y}{Z}";

    }
    public Point(int x, int y, int z)
    {
       X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object obj)
    {
        var temp = obj as Point;

        if (temp.X == X && temp.Y == Y && temp.Z == Z)
            return true;
        return false;

    }

    public override int GetHashCode()
    {
        return AllCoord.GetHashCode();
    }

    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}