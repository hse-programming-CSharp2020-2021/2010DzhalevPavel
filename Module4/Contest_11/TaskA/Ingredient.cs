using System;
using System.Runtime.Serialization;

[DataContract]
[KnownType(typeof(Meat))]
[KnownType(typeof(Vegetable))]
public class Ingredient : IComparable<Ingredient>
{
    [DataMember]
    public string Name { get; set; }
    
    [DataMember]
    protected int TimeToCook { get; set; }

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }

    public int CompareTo(Ingredient other)
    {
        if (other.TimeToCook < TimeToCook)
            return -1;
        if (other.TimeToCook == TimeToCook)
            return 0;
        return 1;
    }

    public override string ToString()
    {
        return Name;
    }
}