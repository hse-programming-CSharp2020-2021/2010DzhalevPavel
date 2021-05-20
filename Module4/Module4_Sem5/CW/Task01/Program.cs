using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task01
{
    interface IVocal
    {
        public void DoSound();
    }

    abstract class Animal : IVocal
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        public bool IsTakenCare { get; set; }
        public void DoSound()
        {
        }

        public Animal(string name, bool isTakenCare)
        {
            var rand = new Random();
            Id = rand.Next(1, 10);
            Name = name;
            IsTakenCare = isTakenCare;
        }

        public override string ToString()
        {
            return
                $"Animal {Name} with id: {Id} is taken care of: {IsTakenCare}";
        }
    }

    class Bird : Animal
    {
        private int _speed;

        public int Speed
        {
            get => _speed;
            set
            {
                if (value < 1 || value > 100)
                    throw new Exception("Wrong value for speed.");
                _speed = value;
            }
        }

        public new void DoSound() => Console.WriteLine("I am a bird, pew, pew, pew!");

        public Bird(string name, bool isTakenCare, int speed) : base(name, 
        isTakenCare)
        {
            Speed = speed;
        }
        public override string ToString()
        {
            return $"Bird {Name} with id: {Id} is taken care of: {IsTakenCare} and has a speed of {Speed}.";
        }
    }
    class Mammal : Animal
    {
        private int _paws;
        private int Paws
        {
            get => _paws;
            set
            {
                if (value < 1 || value > 20)
                    throw new Exception(
                        "Paws cannot be less than 1 and more than 20");
                _paws = value;
            }
        }

        public new void DoSound() => Console.WriteLine("I am a mammal, bi, bi, bi!");

        public Mammal(string name, bool isTakenCare, int paws) : base(name, 
        isTakenCare)
        {
            Paws = paws;
        }

        public override string ToString()
        {
            return
                $"Mammal {Name} with id: {Id} is taken care of: {IsTakenCare} and has {Paws} paws.";
        }
    }

    class Zoo : IEnumerable<Animal>
    {
        private List<Animal> Animals { get; set; } = new List<Animal>();

        public Zoo(int numberOfAnimals)
        {
            var rand = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                int j = rand.Next(1, 3);
                if (j == 1)
                {
                    //Create a bird
                    string name = rand.Next(1, 100000000).ToString();
                    bool isTakenCare = rand.Next(1, 10)% 2 == 0;
                    int speed = rand.Next(1, 100);
                    Animals.Add(new Bird(name, isTakenCare, speed));
                }
                else
                {
                    //Create a mammal
                    string name = rand.Next(1, 100000000).ToString();
                    bool isTakenCare = rand.Next(1, 10) % 2 == 0;
                    int paws = rand.Next(1, 20);
                    Animals.Add(new Mammal(name, isTakenCare, paws));
                }
            }
        }
        public IEnumerator<Animal> GetEnumerator()
        {
            return Animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());

            var zoo = new Zoo(n);
            foreach (var animal in zoo)
            {
                Console.WriteLine(animal);
                animal.DoSound();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Birds with guardian:");
            Console.ForegroundColor = default;
            var birdsWithGuardians =
                from animal in zoo
                where animal is Bird && animal.IsTakenCare
                select animal;
            foreach (var animal in birdsWithGuardians)
            {
                Console.WriteLine(animal);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mammals without a guardian:");
            Console.ForegroundColor = default;
            var mammalsWithoutAGuardian =
                from animal in zoo
                where animal is Mammal && !animal.IsTakenCare
                select animal;
            foreach (var animal in mammalsWithoutAGuardian)
            {
                Console.WriteLine(animal);
            }
        }
    }
}