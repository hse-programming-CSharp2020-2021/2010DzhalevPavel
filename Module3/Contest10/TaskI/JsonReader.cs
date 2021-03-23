using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class JsonReader
{
    public House[] Houses { get;}
    public double MaxTemp { get; }
    public JsonReader(string path)
    {
        var content = File.ReadAllLines(path);
        
        //TODO: Read Json

        Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            {'[', ']'},
            {'{', '}'},
        };
        var stack = new Stack<char>();
        foreach (var c in content[0])
        {
            if (brackets.Keys.Contains(c))
            {
                stack.Push(c);
            }
        }
        MaxTemp = double.Parse(content[1]);
    }

    public string TheSickestStreet
    {
        get
        {
            string illestHouse = string.Empty;
            int mostIllStudents = 0;
            foreach (var house in Houses)
            {
                var illStudents = 0;
                foreach (var student in house.Students)
                {
                    if (student.Temperature >= MaxTemp)
                    {
                        illStudents++;
                    }
                        
                }

                if (mostIllStudents < illStudents)
                {
                    mostIllStudents = illStudents;
                    illestHouse = house.Street;
                }
            }

            return illestHouse;
        }
    }
}