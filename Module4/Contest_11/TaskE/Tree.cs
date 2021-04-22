using System;
using System.Xml.Serialization;

[XmlInclude(typeof(Ash))]
[XmlInclude(typeof(Oak))]
public class Tree : IComparable<Tree>
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public Tree(int height, int age)
    {
        this.height = height;
        this.age = age;
    }

    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }

    public int CompareTo(Tree maxTree)
    {
        if (maxTree.height < height)
            return 1;
        if (maxTree.height == height)
            return 0;
        return -1;
    }
}