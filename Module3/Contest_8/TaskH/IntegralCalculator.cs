using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegralCalculator
{
    public static void InsertParameter(int param)
    {
        switch (param)
        {
            case 0:
                Program.func = CalcIntFromSin;
                break;
            case 1:
                Program.func = CalcIntFromCos;
                break;
            case 2:
                Program.func = CalcIntFromTan;
                break;
        }
    }

    static double CalcIntFromSin(double a, double b)
    {
        double integral = 0;
        for (double i = a; i < b; i+=Program.EPSYLON)
        {
            integral += (Math.Sin(i) + Math.Sin(i + Program.EPSYLON)) / 2 * Program.EPSYLON;
        }
        return integral;
    }
    static double CalcIntFromCos(double a, double b)
    {
        double integral = 0;
        for (double i = a; i < b; i+=Program.EPSYLON)
        {
            integral += (Math.Cos(i) + Math.Cos(i + Program.EPSYLON)) / 2 * Program.EPSYLON;
        }
        return integral;
    }
    static double CalcIntFromTan(double a, double b)
    {
        double integral = 0;
        for (double i = a; i < b; i+=Program.EPSYLON)
        {
            integral += (Math.Tan(i) + Math.Tan(i + Program.EPSYLON)) / 2 * Program.EPSYLON;
        }
        return integral;
    }
}

