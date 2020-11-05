using System;

namespace Schedule
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public Person (string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return $"Person - {Name}";
            }
        }

        class People
        {
            Person[] data;

            public Person[] Data
            {
                get
                {
                    Person[] data2 = new Person[data.Length];
                    for (int i = 0; i < data.Length; i++)
                        data2[i] = new Person(data[i].Name);
                    return data2;
                }
                set
                {
                    Person[] data2 = new Person[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        data2[i] = new Person(value[i].Name);
                    data = data2;
                }
            }

            public People(Person[] data)
            {
                Person[] data2 = new Person[data.Length];
                for (int i = 0; i < data.Length; i++)
                    data2[i] = new Person(data[i].Name);
                Data = data2;
            }

            public Person this[int index]
            {
                get
                {
                    return new Person(data[index].Name);
                }
                set
                {
                    data[index] = new Person(value.Name);
                }
            }

            public void Print()
            {
                Console.WriteLine("People: ");
                for (int i = 0; i < data.Length; i++)
                    Console.WriteLine(data[i].ToString());
            }
        }

        static void Main(string[] args)
        {
            Person[] person = new Person[]
            {
                new Person("A"),
                new Person("B"),
                new Person("C")
            };
            People people = new People(person);
            people.Print();
            person[0].Name = "AAA";
            people.Print();

            Person[] people1 = people.Data;
            people.Print();
            people1[1].Name = "BBB";
            people.Print();

            Person person1 = new Person("person1");
            people[0] = person1;
            people.Print();
            person1.Name = "3456789";
            people.Print();
        }
    }
}