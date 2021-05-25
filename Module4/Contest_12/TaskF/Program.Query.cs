using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        int maxTail = 0;
        foreach (var cat in cats)
        {
            if (cat.TailLength > maxTail)
                maxTail = cat.TailLength;
        }
        
        var result = from cat in cats
            where cat.TailLength >= minTailLength && cat
                .TailLength <= maxTailLength && cat.Age <= maxAge && cat
                .IsBlack || cat.TailLength == maxTail
            select cat;
        
        return result.ToList(); 
    }
}