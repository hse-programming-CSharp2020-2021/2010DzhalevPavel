using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class SimpleFurnitureSerializer
{
    public void Serialize(List<Furniture> furniture, string outputPath)
    {
        var xs = new XmlSerializer(typeof(List<Furniture>));
        using (var fs = new FileStream(outputPath, FileMode.Create))
        {
            xs.Serialize(fs, furniture);
        }
    }
}