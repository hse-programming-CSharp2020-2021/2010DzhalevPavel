using System;

public delegate void Calc(ref double x);


class StackCalculator
{
    
    public static void CreateRules(int[] args)
    {
        foreach (var command in args)
        {
            switch (command)
            {
                case 0:
                    Program.func += CalcSin;
                    break;
                case 1:
                    Program.func += CalcCos;
                    break;
                case 2:
                    Program.func += CalcTan;
                    break;
            }
        }
    }
    
    
    public static void CalcSin (ref double d) => d = Math.Sin(d);
    public static void CalcCos (ref double d) => d = Math.Cos(d);
    public static void CalcTan (ref double d) => d = Math.Tan(d);

}

