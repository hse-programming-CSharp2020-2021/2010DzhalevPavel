using System;
using System.IO;

public class Summator
{
    private string path;
    public Summator(string path)
    {
        this.path = path;
    }
    
    public int Sum
    {
        get
        {
            int sum = 0;
            using (var sr = new StreamReader(path))
            {
                do
                {
                    var numbers = sr.ReadLine().Split('_');
                    foreach (var n in numbers)
                    {
                        sum += int.Parse(n);
                    }
                } while (!sr.EndOfStream);
                
            }

            return sum;
        }
    }
}