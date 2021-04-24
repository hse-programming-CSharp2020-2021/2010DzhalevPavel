using System;

public class MartianInt
{
    private int value;
    private static int count = 0;
    
    public MartianInt(int value)
    {
        Value = value;
    }

    public int Value
    {
        get => value;
        set
        {
            if (value < 0)
            {
                count++;
                throw new ArgumentException("Value is negative")
                    ;
            }

            
            this.value = value;
        }
    }

    public static explicit operator int(MartianInt a)
    {
        var result =  a.value + count;
        count++;
        return result;
    }
    public static implicit operator MartianInt(int a)
    {
        var result = new MartianInt(a-count);
        count++;
        return result;
    }
}