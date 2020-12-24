using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    static int totalFinds = 0;
    private int age;
    private int weight;
    private string name;
    private int index;

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Incorrect age");
            age = value;
        }
    }

    public int Weight
    {
        get => weight;
        set
        {
            if(value <= 0)
                throw new ArgumentException("Incorrect weight");
            weight = value;
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (value == "?")
                throw new ArgumentException("Undefined name");
            name = value;
        }
    }

    public static int TotalFindsNumber
    { 
        get => totalFinds;
        set => totalFinds = value;
    }

    public ArchaeologicalFind(int age, int weight, string name)
    {
        Age = age;
        Weight = weight;
        Name = name;
        index = TotalFindsNumber;
    }
    
    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        bool exist = false;
        foreach (var find in finds)
        {
            if (find.Equals(archaeologicalFind))
                exist = true;
        }
        if(!exist)
            finds.Add(archaeologicalFind);
        TotalFindsNumber++;
    }


    public override bool Equals(object obj)
    {
        var other = obj as ArchaeologicalFind;

        if (other != null)
        {
            if (other.Age == Age && other.name == Name && other.Weight == Weight)
                return true;
            return false;
        }
        throw new ArgumentException("Object could not be evaluated.");
    }
    
    
    public override string ToString() => $"{index} {Name} {Age} {Weight}";
}