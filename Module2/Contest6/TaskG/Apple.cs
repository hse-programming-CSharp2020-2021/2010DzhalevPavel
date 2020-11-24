using System;

public class Apple
{
    private double weight;
    private string color;
    
    public double Weight
    {
        get => weight;
        set {
            if(value<=0||value>1000)
                throw new ArgumentException("Incorrect input");
            weight = value;
        }
    }
    public string Color
    {
        get => color;
        set
        {
            char firstChar = value.ToCharArray()[0];
            if(value.Length>5||firstChar<'A'||firstChar>'Z')
                throw new ArgumentException("Incorrect input");
            color = value;
        }
    }

    public override string ToString()
    {
        return $"{Color} Apple. Weight = {Weight:f2}g.";
    }
}