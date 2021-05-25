using System;
using System.Collections;
using System.Collections.Generic;

public class OnlyEven : IEnumerable<int>
{
    private List<int> numbers;
    
    public OnlyEven(List<int> numbers)
    {
        this.numbers = numbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var number in numbers)
        {
            if(number%2 == 0)
                yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/*public class OnlyEvenEnum : IEnumerator<int>
{
    private List<int> numbers;
    private int position = -1;
    private int _current;

    public OnlyEvenEnum(List<int> numbers)
    {
        this.numbers = numbers;
    }
    
    public bool MoveNext()
    {
        position++;
        return (position < numbers.Count-1);
    }

    public void Reset()
    {
        position = -1;
    }

    int IEnumerator<int>.Current => _current;

    public object? Current
    {
        get
        {
            try
            {
                return numbers[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }

    public void Dispose()
    {
        //numbers = null;
    }
}*/