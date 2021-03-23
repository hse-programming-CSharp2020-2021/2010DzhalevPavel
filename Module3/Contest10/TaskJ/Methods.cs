using System;
using System.Collections.Generic;
using System.Xml;

public class Methods
{
    public static XmlDocument GetDocument(string company, List<string> persons)
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("company");
        XmlAttribute name = doc.CreateAttribute("name");
        name.Value = company;
        root.Attributes.Append(name);
        doc.AppendChild(root);

        var people = new List<Person>();
        foreach (var person in persons)
        {
            var properties = person.Split("\t");
            people.Add(new Person(properties[0], properties[1], properties[2], properties[3]));
        }


        #region Boss

        var bossElement = doc.CreateElement("person");
        XmlAttribute bossid = doc.CreateAttribute("id");
        bossid.Value = people[0].Id;
        bossElement.Attributes.Append(bossid);
        XmlAttribute bossName = doc.CreateAttribute("name");
        bossName.Value = people[0].Name;
        bossElement.Attributes.Append(bossName);
        XmlAttribute bossPosition = doc.CreateAttribute("position");
        bossPosition.Value = people[0].Job;
        bossElement.Attributes.Append(bossPosition);
        root.AppendChild(bossElement);

        #endregion
        
        for (var index = 1; index < people.Count; index++)
        {
            var personElement = doc.CreateElement("person");
            XmlAttribute id = doc.CreateAttribute("id");
            id.Value = people[index].Id;
            personElement.Attributes.Append(id);
            XmlAttribute personName = doc.CreateAttribute("name");
            personName.Value = people[index].Name;
            personElement.Attributes.Append(personName);
            XmlAttribute position = doc.CreateAttribute("position");
            position.Value = people[index].Job;
            personElement.Attributes.Append(position);
            
            var a = doc.SelectNodes("//person[@id='"+people[index].BossId+"']");
            a?[0].AppendChild(personElement);
        }

        return doc;
        
    }
    
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string BossId { get; set; }
        public string Job { get; set; }

        public Person(string id, string boss, string job, string name)
        {
            Name = name;
            Id = id;
            BossId = boss;
            Job = job;
        }
    }
}