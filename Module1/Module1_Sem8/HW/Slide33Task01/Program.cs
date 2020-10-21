using System;
using System.IO;
using System.Linq;

namespace Slide33Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";
            string text = "";
            try
            {
                text = File.ReadAllText(inputPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int[] numbers = new int[text.Split(" ").Length];
            bool[] newArr = new bool[text.Split(" ").Length];
            for (int i = 0; i < text.Split(" ").Length; i++)
            {
                if (!int.TryParse(text.Split(" ")[i], out numbers[i])
                    ||numbers[i]>10||numbers[i]<-10)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                if (numbers[i] >= 0)
                    newArr[i] = true;
                else newArr[i] = false;
            }

            string output = "";
            
            foreach (bool value in newArr)
            {
                output += $"{value} ";
            }
            try
            {
                File.WriteAllText(outputPath, output);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}