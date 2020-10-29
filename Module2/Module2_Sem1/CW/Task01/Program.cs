using System;
using System.Threading;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] arr = new char[][][]
            {
                new char[][]
                {
                    new char[] {'a', 'b'},
                    new char[] {'c', 'd', 'e'},
                    new char[] {'f', 'g', 'h', 'i'},
                },
                new char[][]
                {
                    new char[] {'j', 'k'},
                    new char[] {'l', 'm', 'n'},
                },
                new char[][]
                {
                    new char[] {'o', 'p', 'q', 'r'},
                }
            };

            foreach (char[][] a in arr)
            {
                foreach (char[] b in a)
                {
                    foreach (char c in b)
                    {
                        Console.Write(c+" ");
                    }
                    Console.WriteLine();
                }   
            }

            Console.WriteLine($"The rank of the array is:{arr.Rank}");
            Console.WriteLine($"The number if elements in this array is:{arr.Length}");
        }
    }
}