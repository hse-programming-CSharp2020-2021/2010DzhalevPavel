using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

public class MyList<T>
{
    private T[] array;
    private int numberOfElements = 0;
    public MyList() => array = new T[0];

    public MyList(int capacity)
    {
        if(capacity>=0)
            array = new T[capacity];
        else
        {
            array = new T[capacity];
        }
    } 
    public int Count => numberOfElements;
    public int Capacity => array.Length;
    
    public void Add(T element)
    {
        if (array.Length == 0)
        {
            array = new T[4];
            array[numberOfElements] = element;
            numberOfElements++;
            return;
        }
        
        if (numberOfElements == array.Length)
        {
            //No more space in array
            T[] temp = new T[array.Length * 2];
            int i = 0;
            for (; i < array.Length; i++)
            {
                temp[i] = array[i];
            }

            temp[i] = element;
            numberOfElements++;
            array = temp;
            return;
        }

        array[numberOfElements] = element;
        numberOfElements++;
    }

    public T this[int x]
    {
        get
        {
            if(x<0 || x > numberOfElements-1)
                throw new IndexOutOfRangeException();
            return array[x];
        }
    }

    public void Clear()
    {
        array = new T[array.Length];
        numberOfElements = 0;
    }

    public void RemoveLast()
    {
        if (array[numberOfElements-1] == null)
        {
            throw new IndexOutOfRangeException();
        }

        array[numberOfElements - 1] = default;
        numberOfElements--;
    }

    public void RemoveAt(int index)
    {
        if (array[index] == null)
        {
            throw new IndexOutOfRangeException();
        }
        array[index] = default;
        for (int i = index; i < array.Length-1; i++)
        {
            array[i] = array[i + 1];
        }

        numberOfElements--;
        array[^1] = default;
    }

    public T Max()
    {
        try
        {
            if (numberOfElements == 0)
                throw new IndexOutOfRangeException();
            var max = array.Max();
            return max;
        }
        catch (IndexOutOfRangeException) { throw new IndexOutOfRangeException(); }
        catch (Exception) { throw new NotSupportedException("This operation is not supported for this type"); }
        
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (var item in array)
        {
            result += item + " ";
        }

        return result;
    }
}