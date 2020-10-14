using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = {"1", "2", "3"};
            File.WriteAllLines("example1.txt", str);

            string[] str2 = File.ReadAllLines("example1.txt");

            foreach (string s in str2)
            {
                Console.WriteLine(s);
            }

            string str3 = File.ReadAllText("example1.txt");
            
        }
    }
}