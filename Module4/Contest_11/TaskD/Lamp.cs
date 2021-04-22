using System;
using System.Xml.Serialization;

public class Lamp : Furniture
{
    [XmlElement("lifeTime")]
    public double LifeTimeSeconds
    {
        get => _lifeTime;
        set => _lifeTime = value;
    }

    private double _lifeTime;

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        _lifeTime = lifeTime.TotalSeconds;
    }

    public Lamp()
    {
    }
}