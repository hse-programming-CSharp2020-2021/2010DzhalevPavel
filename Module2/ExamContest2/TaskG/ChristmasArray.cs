using System;
using System.Collections.Generic;
using System.Linq;

internal class ChristmasArray : BaseArray
{
    public ChristmasArray(int[] array) : base(array)
    {
        this.array = array;
    }

    public override int this[int number]
    {
        
        get
        {
            List<int> l = new List<int>();
            foreach (var n in array)
            {
                if(n< number)
                    l.Add(n);
            }

            if (l.Count == 0)
                throw new ArgumentException("Number does not exist.");

            return l.Max();
        }
    }
    

    public override double GetMetric()
    {
        int c = 0;
        double sum = 0;
        foreach (var item in array)
        {
            sum += item.ToString().Length;
            foreach (var letter in item.ToString())
            {
                if ('6' == letter)
                    c++;
            }
        }

        return c / sum;
    }
}