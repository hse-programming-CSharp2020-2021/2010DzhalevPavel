using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        var result = from cat in cats
            where cat.TailLength >= minTailLength && cat
                .TailLength <= maxTailLength && cat.Age <= maxAge && cat
                .IsBlack
            select cat;
        
        return result.ToList();
    }
}