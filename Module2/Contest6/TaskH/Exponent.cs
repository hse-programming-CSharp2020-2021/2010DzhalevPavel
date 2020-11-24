using System;

public class Exponent : Function
{
    public override double GetValueInX(double x)
    {
        if(Double.IsNaN(Math.Exp(1/x)) || Double.IsInfinity(Math.Exp(1 / x)))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        return Math.Exp(1 / x);
    }
}
