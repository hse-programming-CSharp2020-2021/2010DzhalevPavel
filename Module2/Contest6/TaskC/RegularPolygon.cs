using System;

public class RegularPolygon : Polygon
{
    private double side;
    private double numberOfSides;
    public RegularPolygon(double side, int numberOfSides)
    {
        if(side<=0)
            throw new ArgumentException("Side length value should be greater than zero.");
        this.side = side;
        if(numberOfSides<3) 
            throw new ArgumentException("Number of sides value should be greater than 3.");
        this.numberOfSides = numberOfSides;
    }

    public override double Perimeter
    {
        get
        {
            return side * numberOfSides;
        }
    }

    public override double Area
    {
        
        get
        {
            double apotem = side/(2*Math.Tan(Math.PI/numberOfSides));
            return Perimeter * apotem / 2;
        }
    }

    public override string ToString()
    {
        return $"side: {side}; numberOfSides: {numberOfSides}; area: {Area:f3}; perimeter: {Perimeter:f3}";
    }
}