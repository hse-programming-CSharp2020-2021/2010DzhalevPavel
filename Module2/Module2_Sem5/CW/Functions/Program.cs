using System;
using System.Net.Security;
using System.Xml.Schema;

namespace Functions
{
    class Program
    {
        abstract class Animal
        {
            private string nick;
            private int age;

            public Animal(string nickname, int age)
            {
                nick = nickname;
                this.age = age;
            }

            public string Nick
            {
                get => nick;
                set => nick = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }

            public abstract string AnimalSound();
            public abstract string AnimalInfo();
        }

        class Dog : Animal
        {
            private string breed;
            private bool isTrained;

            public Dog(string b, bool i, string n, int a) : base(n, a)
            {
                breed = b;
                isTrained = i;
                Nick = n;
                Age = a;
            }

            public string Breed
            {
                get => breed;
                set
                {
                    if (value == null)
                        throw new ArgumentException("Dogs always have nicknames!");
                    Nick = value;
                }
            }

            public bool IsTrained
            {
                get => isTrained;
                set => isTrained = value;
            }

            public override string AnimalSound()
            {
                return "Bow";
            }

            public override string AnimalInfo()
            {
                return $"This is a dog named {Nick}, which is trained - {IsTrained}, is {Age} years old" +
                       $", is a {Breed} and says {AnimalSound()}";
            }
        }

        class Cow : Animal
        {
            private double milkPerDay;

            public double MilkPerDay
            {
                get => milkPerDay;
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Milks always give some milk per day!");
                    milkPerDay = value;
                }
            }

            public Cow(double m, string n, int a) : base(n, a)
            {
                milkPerDay = m;
                Nick = n;
                Age = a;
            }

            public override string AnimalSound()
            {
                return "Muuu";
            }

            public override string AnimalInfo()
            {
                return $"This is a milk named {Nick}, which is {Age} years old, says {AnimalSound()}" +
                       $"and gives {milkPerDay} litres of milk every day.";
            }
        }

        static void Main(string[] args)
        {
            var dog = new Dog("Bulldog", true, "Symba", 5);
            var cow = new Cow(10, "Milka", 12);

            Console.WriteLine(dog.AnimalInfo());
            Console.WriteLine(cow.AnimalInfo());

            

        }
    }
}