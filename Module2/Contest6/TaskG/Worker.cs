using System;
using System.Collections;
using System.Globalization;

public class Worker
{
    private Apple[] apples;

    public Worker(Apple[] apples)
    {
        this.apples = apples;
    }

    public Apple[] GetSortedApples()
    {
        Apple[] sortedApples = new Apple[apples.Length];
        for (int i = 0; i < apples.Length; i++)
        {
            sortedApples[i] = apples[i];
        }
        Array.Sort(sortedApples, new ApplesComparer());
        
        return sortedApples;
    }

    class ApplesComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            return (new Comparer(CultureInfo.CurrentCulture)).Compare(((Apple)a).Weight, ((Apple)b).Weight);
        }
    }
}
