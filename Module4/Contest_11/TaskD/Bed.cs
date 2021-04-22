using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Bed : Furniture
{
    [XmlElement("pillow")]
    public Pillow[] Pillows;

    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        Pillows = new Pillow[pillows.Count];
        for (int i = 0; i < pillows.Count; i++)
        {
            Pillows[i] = pillows[i];
        }
    }

    public Bed()
    {
    }
}