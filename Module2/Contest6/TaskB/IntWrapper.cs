using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    private readonly int n;
    public IntWrapper(int number)
    {
        n = number;
    }

    public int FindNumberLength()
    {
        if (n < 0)
            throw new ArgumentException("Number should be non-negative.");
        return n.ToString().Length;
    }
}
