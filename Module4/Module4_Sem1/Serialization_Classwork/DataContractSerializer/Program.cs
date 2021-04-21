using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

 

namespace Task_1
{
    /*
     <Candidate xmlns="http://schemas.datacontract.org/2004/07/Task_1"
    xmlns:i="http://www.w3.org/2001/XMLSchema-instance">
    <Age>35</Age>
    <FirstName>Tom</FirstName></Candidate>
     */
    //[Serializable]
    [DataContract(IsReference = true)]
    public class Person
    {
        [DataMember(Name = "FirstName")]
        [JsonPropertyName("FirstName")]
        public string Name { get; set; }
        [DataMember]
        [JsonIgnore]
        public int Age { get; set; }
        [DataMember] public Address HomeAddress, WorkAddress;
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public Person()
        {

 

        }
    }

 

    [DataContract(IsReference = true)]
    public class Address
    {
        [DataMember] public string Street, Postcode;
    }

 

    [DataContract] public class Student : Person { }
    [DataContract] public class Teacher : Person { }

 


    /*
     
     <Candidate xmlns="http://schemas.datacontract.org/2004/07/Task_1" xmlns:i="http://www.w3.org/2001/XMLSchema-instance"><Age>30</Age><FirstName>Stacey</FirstName><HomeAddress><Postcode>6020</Postcode><Street>Odo St</Street></HomeAddress><WorkAddress><Postcode>6020</Postcode><Street>Odo St</Street></WorkAddress></Candidate>
     
     
     
     <Person z:Id="i1" xmlns="http://schemas.datacontract.org/2004/07/Task_1" xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns:z="http://schemas.microsoft.com/2003/10/Serialization/"><Age>30</Age><FirstName>Stacey</FirstName><HomeAddress z:Id="i2"><Postcode>6020</Postcode><Street>Odo St</Street></HomeAddress><WorkAddress z:Ref="i2"/></Person>
     */
    class Program {
        private static void Main(string[] args)
        {
            Person p = new Person { Name = "Stacey", Age = 30 };
            p.HomeAddress = new Address { Street = "Odo St", Postcode = "6020" };
            p.WorkAddress = p.HomeAddress;

 

            DataContractSerializer ds = new DataContractSerializer(typeof(Person),
                new Type[] { typeof(Student) });

 

            using (Stream s = File.Create("person.xml"))
                ds.WriteObject(s, p); // Сериализация

 

            Person p2;
            using (Stream s = File.OpenRead("person.xml"))
                p2 = (Person)ds.ReadObject(s); // Десериализация
            Console.WriteLine(p2.Name + " " + p2.Age);
            Console.WriteLine(p2.WorkAddress.Street);
            p2.WorkAddress.Street = "1";
            Console.WriteLine(p2.HomeAddress.Street);

 

            //Person tom = new Person("Tom", 35);
            //string json = JsonSerializer.Serialize<Person>(tom);
            //Console.WriteLine(json);

 

            //Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            //Console.WriteLine(restoredPerson.Name);
            //Console.WriteLine(restoredPerson.Age);
        }

 

        //static async Task Main(string[] args)
        //{
        //    // сохранение данных
        //    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        //    {
        //        Person tom = new Person( "Tom", 35 );
        //        await JsonSerializer.SerializeAsync<Person>(fs, tom);
        //        Console.WriteLine("Data has been saved to file");
        //    }

 

        //    // чтение данных
        //    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        //    {
        //        Person restoredPerson = await JsonSerializer.DeserializeAsync<Person>(fs);
        //        Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
        //    }
        //}
    }
}