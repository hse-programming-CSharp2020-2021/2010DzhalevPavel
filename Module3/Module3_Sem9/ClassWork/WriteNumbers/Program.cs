using System;
using System.Collections.Generic;
using System.IO;

namespace WriteNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            
            //Write random numbers
            using (var bw = new BinaryWriter(File.Open("numbers.bin", FileMode.Create)))
            {
                for (int i = 0; i < 10; i++)
                {
                    bw.Write(rand.Next(1, 100));
                }
            }

            var numbers = new List<int>();
            using (var br = new BinaryReader(File.Open("numbers.bin", FileMode.Open)))
            {
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    int currentNumber = br.ReadInt32();
                    numbers.Add(currentNumber);
                    Console.WriteLine(currentNumber);
                }

                int n;
                do
                {
                    Console.Write("New number:");
                } while (!int.TryParse(Console.ReadLine(), out n));

                int difference = 100;
                int closest = 0;
                foreach (var num in numbers)
                {
                    if (Math.Abs(num - n) < difference)
                    {
                        difference = Math.Abs(num - n);
                        closest = num;
                    }
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == closest)
                        numbers[i] = n;
                }

                foreach (var i in numbers)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}