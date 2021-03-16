using System;
using System.Collections;
using System.Collections.Generic;

namespace Task02
{
    struct Person
    {
        public string Name { get; set; }
        public string Surname{ get; set; }
        public int Age{ get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    class ElectronicQueue<T>
    {
        public Queue<T> _queue = new Queue<T>();

        public void Enqueue(T o)
        {
            _queue.Enqueue(o);
        }

        public void Dequeue()
        {
            _queue.Dequeue();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ElectronicQueue<Person>();
            
            a.Enqueue(new Person("John", "Travolta", 55));
            a.Enqueue(new Person("Sam", "Smith", 65));
            a.Enqueue(new Person("Tim", "Cook", 25));

            foreach (var p in a._queue)
            {
                Console.WriteLine($"{p.Name} {p.Surname} is {p.Age} years old.");
            }

            a.Dequeue();

            foreach (var p in a._queue)
            {
                Console.WriteLine($"{p.Name} {p.Surname} is {p.Age} years old.");
            }

        }
    }
}