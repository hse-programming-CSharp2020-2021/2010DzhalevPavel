using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class RandomProxy
{
    StreamWriter log;
    Random rand = new Random(1579);

    static Dictionary<string, int> users = new Dictionary<string, int>();

    public RandomProxy(StreamWriter log)
    {
        this.log = log;
    }

    public void Register(string login, int age)
    {
        if(users.ContainsKey(login))
            throw new ArgumentException($"User {login}: login is already registered");
        users.Add(login, age);
        log.WriteLine($"User {login}: login registered");
    }

    public int Next(string login)
    {
        if(!users.ContainsKey(login))
            throw new ArgumentException($"User {login}: login is not registered");
        int r;
        if (users[login] < 20)
        {
            r = rand.Next(0, 1000);
            log.WriteLine($"User {login}: generate number {r}");
            return r;
        }
        r = rand.Next(0, int.MaxValue);
        log.WriteLine($"User {login}: generate number {r}");
        return r;
    }

    public int Next(string login, int maxValue)
    {
        if(!users.ContainsKey(login))
            throw new ArgumentException($"User {login}: login is not registered");
        if(maxValue>1000 && users[login]<20)
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        int r = rand.Next(0, maxValue);
        log.WriteLine($"User {login}: generate number {r}");
        return r;
    }

    public int Next(string login, int minValue, int maxValue)
    {
        if(!users.ContainsKey(login))
            throw new ArgumentException($"User {login}: login is not registered");
        if(maxValue>1000 && users[login]<20)
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        int r = rand.Next(minValue, maxValue);
        log.WriteLine($"User {login}: generate number {r}");
        return r;
    }

}
