using System;

public class Rational
{
    int numerator;
    int denomenator;

    public Rational(int num, int den)
    {
        numerator = num;
        denomenator = den;
    }

    public static Rational Parse(string input)
    {
        var number = input.Split('/');
        if (number.Length == 1)
        {
            return new Rational(int.Parse(number[0]), 1);
        }

        if (int.TryParse(number[0], out int num) && int.TryParse(number[1], out
            int den))
            return new Rational(num, den);
        return null;
    }

    public override string ToString()
    {
        checkPrime(this);
        if (numerator == 0)
            return "0";
        if (denomenator < 0)
        {
            numerator *= -1;
            denomenator*=-1;
            return ToString();
        }

        if (denomenator == 1)
            return numerator.ToString();
        if (numerator == denomenator)
            return "1";
        if (numerator == -denomenator)
            return "-1";
        if (numerator < 0 && denomenator < 0)
        {
            numerator *= -1;
            denomenator*=-1;
            return ToString();
        }
        return numerator + "/" + denomenator;
    }

    public static Rational operator +(Rational a, Rational b)
    {
        if(a.denomenator == b.denomenator)
            return new Rational(a.numerator + b.numerator,
            a.denomenator);
        return new Rational(
            a.numerator * b.denomenator + b.numerator * a.denomenator, a
                .denomenator * b
                .denomenator);
    }
    public static Rational operator -(Rational a, Rational b)
    {
        if(a.denomenator == b.denomenator)
            return new Rational(a.numerator - b.numerator,
                a.denomenator);
        return new Rational(
            a.numerator * b.denomenator - b.numerator * a.denomenator, a
                .denomenator * b
                .denomenator);
    }
    public static Rational operator *(Rational a, Rational b)
    {
        return new Rational(a.numerator * b.numerator,
            a.denomenator * b.denomenator);
    }
    public static Rational operator /(Rational a, Rational b)
    {
        return new Rational(a.numerator * b.denomenator,
            a.denomenator * b.numerator);
    }

    /// <summary>
    /// Checks whether this si the most simplified form.
    /// </summary>
    /// <param name="one"></param>
    public static void checkPrime(Rational one)
    {
        var bigger = 0;
        if (one.numerator > one.denomenator)
            bigger = one.numerator;
        else bigger = one.denomenator;

        for (int i = 2; i < bigger; i++)
        {
            if (one.denomenator % i == 0 && one.numerator % i == 0)
            {
                one.denomenator /= i;
                one.numerator /= i;
                i--;
            }
        }
    }
}