using System;
using System.Collections.Generic;

public class Grassland
{
    private List<Sheep> sheep;
    public Grassland(List<Sheep> sheeps)
    {
        sheep = sheeps;
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> newList = new List<Sheep>();
        foreach (Sheep sheep in sheep)
        {
            if(sheep.Id%2==0)
                newList.Add(sheep);
        }
        return newList;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> newList = new List<Sheep>();
        foreach (Sheep sheep in sheep)
        {
            if(sheep.Id%2==1)
                newList.Add(sheep);
        }
        return newList;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> newList = new List<Sheep>();
        foreach (Sheep sheep in sheep)
        {
            if(sheep.Name.Contains(name))
                newList.Add(sheep);
        }
        return newList;
    }
}
