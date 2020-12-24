using System;

class Brigantine : Boat
{
    public Brigantine(int value, bool isAtTheThePort) : base(value, isAtTheThePort)
    {
        Cost = value;
        IsAtThePort = isAtTheThePort;
    }

    public new int CountCost(int weight)
    {
        if (weight <= 500)
            return weight * Cost * Cost;
        return weight * Cost;
    }
}