using System;

public class IntWrapper
{
    private int number;

    public int Number
    {
        get => number;
        set => number = value;
    }

    public IntWrapper(int number)
    {
        Number = number;
    }

    public uint FindNumberLength()
    {
        if (number < 0) throw new ArgumentException("Number should be non-negative.");
        return (uint)number.ToString().Length;
    }
}
