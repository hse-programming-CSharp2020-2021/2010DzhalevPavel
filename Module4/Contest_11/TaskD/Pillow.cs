using System;
using System.Xml.Serialization;

[Serializable]
public class Pillow
{
    [XmlElement("id")]
    public long Id { get; set; }
    
    [XmlElement("isRuined")]
    public string IsRuinedStr
    {
        get => isR ? "Yes" : "No";
        set => isR = value == "Yes" ? true :  false;
    }
    private bool isR;

    

    public Pillow(long id, bool isRuined)
    {
        isR = isRuined;
        Id = id;
    }

    public Pillow()
    {
    }
}