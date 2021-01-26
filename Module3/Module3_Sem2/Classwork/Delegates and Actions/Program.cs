using System;

namespace Delegates_and_Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            var plants = new Plant[n];

            var rand = new Random();

            for (int i = 0; i < plants.Length; i++)
            {
                plants[i] = new Plant(rand.NextDouble() * 75 + 25, rand.NextDouble() * 100,
                    rand.NextDouble() * 80);
            }
            
            Array.ForEach(plants, plant => Console.WriteLine(plant.ToString()));

            Console.WriteLine("Array sorted by growth:");
            Array.Sort(plants, (Plant plant, Plant plant1) =>
            {
                if (plant.Growth < plant1.Growth) return 1;
                if (plant.Growth == plant1. Growth) return 0;
                return -1;
            });
            
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            
            //Sort 
            Console.WriteLine("Array sorted by frostresistance:");
            Array.Sort(plants, (Plant plant, Plant plant1) =>
            {
                if (plant.Frostresistance > plant1.Frostresistance) return 1;
                if (plant.Frostresistance == plant1.Frostresistance) return 0;
                return -1;
            });
            Array.ForEach(plants, Console.WriteLine);
            
            
            Console.WriteLine("Array sorted by photosensitivity:");
            Array.Sort(plants, (Plant plant, Plant plant1) =>
            {
                if ((int)plant.Photosensitivity % 2 != 0  && (int)plant1.Photosensitivity%2==0) return 1;
                if (plant.Photosensitivity == plant1.Photosensitivity) return 0;
                return -1;
            });
            Array.ForEach(plants, Console.WriteLine);
            
            Console.WriteLine("Array converted:");
            var newPlants  = Array.ConvertAll(plants, ConvertPlant);
            Array.ForEach(newPlants, Console.WriteLine);
        }
        
        public static Plant ConvertPlant(Plant old)
        {
            if ((int) old.Frostresistance % 2 == 0)
                return new Plant(old.Growth, old.Photosensitivity, old.Frostresistance/3);
            if ((int) old.Frostresistance % 2 == 1)
                return new Plant(old.Growth, old.Photosensitivity, old.Frostresistance/2);
            return old;
        }
    }

    class Plant
    {
        private double growth;
        private double photsensitivity;
        private double frostresistance;

        public double Growth
        {
            get => growth;
            set
            {
                if (value > 100 || value < 0)
                    throw new ArgumentException("Value for growth false");
                growth = value;
            }
        }
        public double Photosensitivity
        {
            get => photsensitivity;
            set
            {
                if (value > 100 || value < 0)
                    throw new ArgumentException("Value for photosensitivity false");
                photsensitivity = value;
            }
        }
        public double Frostresistance
        {
            get => frostresistance;
            set
            {
                if (value > 100 || value < 0)
                    throw new ArgumentException("Value for frostresistance false");
                frostresistance = value;
            }
        }

        public Plant(double g, double p, double f)
        {
            Growth = g;
            Photosensitivity = p;
            Frostresistance = f;
        }

        public override string ToString()
        {
            return $"Growth: {Growth:f3} | Photosensitivity: {Photosensitivity:f3} | " +
                   $"Frostresistance: {Frostresistance:f3}";
        }
    }
    
}