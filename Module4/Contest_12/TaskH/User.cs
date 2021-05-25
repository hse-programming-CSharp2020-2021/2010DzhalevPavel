using System;
using System.Linq;

public class User
{
    private ushort age;
    private string city;
    private long id;
    private string name;

    private User(long id, string name, ushort age, string city)
    {
        Id = id;
        Name = name;
        Age = age;
        City = city;
    }

    private long Id
    {
        get => id;
        set
        {
            if (value <= 0) throw new ArgumentException("Incorrect input");
            id = value;
        }
    }

    public string Name
    {
        get => name;
        private set
        {
            if(value.Any(char.IsDigit)) throw new ArgumentException("Incorrect input");
            name = value;
        }
    }

    public ushort Age
    {
        get => age;
        private set
        {
            if(value > 128)throw new ArgumentException("Incorrect input");
            age = value;
        }
    }

    public string City
    {
        get => city;
        private set
        {
            city = value;
        }
    }

    public static User Parse(string str)
    {
        var user = str.Split(';');
        
        if (user.Length != 4) throw new ArgumentException("Incorrect input");
        
        return new User(
            long.Parse(user[0]),
            user[1],
            ushort.Parse(user[2]),
            user[3]
            );
    }
}