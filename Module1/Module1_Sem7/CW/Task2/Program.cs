using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            
            //Converts int to base 2.
            string str = Convert.ToString(number,2);
            
            //Test output.
            Console.WriteLine($"Our number in base 2 is: {str}");

            //Writes the number in base 2 to file.
            File.WriteAllText("IntNumber.txt", str);

            //Read and convert file to decimal.
            if (File.Exists("IntNumber.txt"))
            {
                Console.WriteLine($"The converted number is: " +
                                  $"{Convert.ToInt32(File.ReadAllText("IntNumber.txt"), 2)}");
            }
            
            
        }
    }
}