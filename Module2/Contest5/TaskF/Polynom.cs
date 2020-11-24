using System;

class Polynom
{
    public static bool TryParsePolynom(string line, out int[] arr)
    {
        int i = 0;
        string[] numbers = line.Split(' ');
        arr = new int[numbers.Length];
        bool flag = true;
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out arr[i]))
                i++;
            else flag = false;
        }

        return flag;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int[] result = new int[Math.Max(a.Length, b.Length)];
        for (int i = 0; i < result.Length; i++)
        {
            if (a.Length >= b.Length)
                if (i >= b.Length)
                    result[i] = a[i];
                else result[i] = b[i] + a[i];
            else
            {
                if (i >= a.Length)
                    result[i] = b[i];
                else result[i] = b[i] + a[i];
            }
        }

        return result;
    }

    public static int[] Dif(int[] a, int[] b)
    {
        if (a.Length >= b.Length) {
            int[] result = new int[a.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i >= b.Length)
                    result[i] = a[i];
                else result[i] = a[i] - b[i];
            }
            return result;
        }
        else {
            int[] result = new int[b.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i >= a.Length)
                    result[i] = -b[i];
                else result[i] = a[i] - b[i];
            }
            return result;
        }
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] * n;
        }

        return result;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length - 1];
        for (int i = a.Length-1; i >= 0; i--)
        {
            for (int j = b.Length-1; j >= 0; j--)
            {
                result[i + j] += a[i] * b[j];
            }
        }
        return result;
    }

    public static string PolynomToString(int[] polynom)
    {
        var result = "";
        for (var i = polynom.Length - 1; i >= 0; i--)
        {
            if (i == 1 && polynom[i] != 0)
            {
                if (result != "")
                    result += " + " + polynom[i] + "x";
                else
                    result += polynom[i] + "x";
            }
            else if (i == polynom.Length - 1 && polynom[i] != 0)
                result += polynom[i] + "x" + $"{i}";
            else if (i == 0 && polynom[i] != 0)
            {
                if (result != "")
                    result += " + " + polynom[i];
                else
                    result += polynom[i];
            }
            else
            {
                if (polynom[i] != 0)
                {
                    if (result != "")
                        result += " + " + polynom[i] + "x" + $"{i}";
                    else
                        result += polynom[i] + "x" + $"{i}";
                }
            }
        }

        if (result == "")
            result = "0";

        return result;
    }
}