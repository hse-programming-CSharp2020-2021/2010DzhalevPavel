using System;
using System.IO;

namespace ChangeStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateRandomFile();
            
            using (var sr = new StreamReader(File.Open("input.txt", FileMode.Open)))
            {
                Console.SetIn(sr);

                int sum = 0, number =0;
                while (!sr.EndOfStream)
                {
                    sum += int.Parse(sr.ReadLine());
                    number++;
                }
                
                Console.WriteLine($"The average is: {sum/number}");

                Console.OpenStandardInput();
            }
            
        }

        public static void CreateRandomFile()
        {
            var rand = new Random();
            
            using (var sw = new StreamWriter(File.Create("input.txt")))
            {
                sw.WriteLine(rand.Next(100, 1000));
            }
        }
    }
}