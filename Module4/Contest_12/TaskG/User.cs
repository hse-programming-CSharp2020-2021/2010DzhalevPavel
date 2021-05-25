using System;
using System.Linq;
using System.Reflection;

public class User
{
    private long id;
    private string name;
    private ushort age;

    public long Id
    {
        get => id;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Incorrect input");
            id = value;
        }
    }
    
    public string Name
    {
        get => name;
        private set
        {
            if (value.Any(char.IsDigit))
                throw new ArgumentException("Incorrect input");
            name = value;
        }
    }
    
    public ushort Age
    {
        get => age;
        private set
        {
            if (value > 128) throw new ArgumentException("Incorrect input");
            age = value;
        }
        
    }

    private User(long id, string name, ushort age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public static User Parse(string str)
    {
        var userInfo = str.Split(';');
        try
        {
            return new User(
                long.Parse(userInfo[0]),
                userInfo[1],
                ushort.Parse(userInfo[2]));
        }
        catch (Exception)
        {
            throw new ArgumentException("Incorrect input");
        }
        
    }
}