using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        string[] args = line.Split(" ");
        return new Sheep(int.Parse(args[4]),args[1], args[6]);
    }
}
