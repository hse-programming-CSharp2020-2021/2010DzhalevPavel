using System;

public class Sin : Function
{
    public override double GetValueInX(double x)
    {
        if(Double.IsNaN(1/Math.Sin(x)) || Double.IsInfinity(1/Math.Sin(x)))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        return 1/Math.Sin(x);
    }
}
