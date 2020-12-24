using System;

class Boat
{
    public int Cost { get; set; }
    public bool IsAtThePort { get; set; }

    public Boat(int value, bool isAtTheThePort)
    {
        Cost = value;
        IsAtThePort = isAtTheThePort;
    }

    public int CountCost(int weight)
    {
        return weight * Cost;
    }
}


