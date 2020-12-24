using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    protected GeometryRef(List<Point> points)
    {
    }

    protected virtual double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSquare()
    {
        throw new NotImplementedException();
    }

    public static GeometryRef Parse(string line)
    {
        /*string[] words = line.Split(' ');
        if(words[0] != "Triangle" &&
           words[0] != "Rectangle" &&
           words[0] != "GeometryRef"|
           words.Length % 2 == 0)
            throw new ArgumentException("Incorrect input");
        return GeometryRef();*/
        throw new NotImplementedException();
    }
}