using System;

public class Parabola : Function
{
    public override double GetValueInX(double x)
    {
        if(Double.IsNaN(x * x + x + 7) || Double.IsInfinity(x * x + x + 7))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        return x * x + x + 7;
    }
}
