using System;
using System.Diagnostics.CodeAnalysis;

public abstract class Function
{
    public static Function GetFunction(string functionName)
    {
        if(functionName!="Sin"&&functionName!="Exp"&&functionName!="Parabola")
            throw new ArgumentException("Incorrect input");
        return functionName switch
        {
            "Sin" => new Sin(),
            "Exp" => new Exponent(),
            "Parabola" => new Parabola(),
            _ => null
        };
    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        double integral=0;
        double steps = (right - left) / step;
        if(right<left)
            throw new ArgumentException("Left border greater than right");
        /*if(double.IsNaN(func.GetValueInX(left))||double.IsNaN(func.GetValueInX(right)))
            throw new ArgumentException("Function is not defined in point");*/
        if(Double.IsNaN(left) || Double.IsInfinity(right))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        if (Double.IsNaN(right) || Double.IsInfinity(left))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        if (Double.IsNaN(step) || Double.IsInfinity(step))
        {
            throw new ArgumentException("Function is not defined in point");
        }
        
        double oldStep=step;
        for (int i = 0; i <= (int)steps; i++)
        {
            if (left + step * (i + 1) > right)
            {
                double n=left+oldStep*i;
                step = right - (left+step*i);
                integral += (func.GetValueInX(n) + func.GetValueInX(n+step)) * step / 2;
            }else
                integral += (func.GetValueInX(left+step*i) + func.GetValueInX(left+step*(i+1))) * oldStep / 2;
        }

        integral = Math.Round(integral, 3);
        return integral;
    }
}
