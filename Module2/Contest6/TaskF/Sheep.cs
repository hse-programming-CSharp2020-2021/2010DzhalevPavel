
using System;
using System.Globalization;

public class Sheep
{
    private int id;
    private string name;
    private string sound;

    public int Id
    {
        get => id;
        set
        {
            if(value<=0||value>999)
                throw new ArgumentException("Incorrect input");
            id = value;
        }
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Sound
    {
        get => sound;
        set => sound = value;
    }

    public Sheep(int id, string name, string sound)
    {
        Id = id;
        Name = name;
        Sound = sound;
    }

    public override string ToString()
    {
        return $"[{Id}-{Name}]: {Sound}...{Sound}";
    }
}
