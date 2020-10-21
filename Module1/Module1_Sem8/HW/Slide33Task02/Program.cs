using System;
using System.IO;

namespace Slide33Task02
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
            int[] newArr = new int[text.Split(" ").Length];
            double temp = 0;
            for (int i = 0; i < text.Split(" ").Length; i++)
            {
                if (!int.TryParse(text.Split(" ")[i], out numbers[i])
                    || numbers[i] > 10000 || numbers[i] <=0)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                else
                {
                    int j = 0;

                    do
                    {
                        temp = Math.Pow(2, j);
                        j++;
                    } while (temp < numbers[i]);
                    newArr[i] = (int) Math.Pow(2, j-2);
                }
            }

            string output = "";

            foreach (int value in newArr)
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