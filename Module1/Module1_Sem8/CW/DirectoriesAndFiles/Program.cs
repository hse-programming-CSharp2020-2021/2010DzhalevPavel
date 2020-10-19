using System;
using System.IO;

namespace DirectoriesAndFiles
{
    /// <summary>
    /// In this project, we will learn about file management and directories
    /// and their usage through .NET.
    /// Always use try-catch blocks when working with files.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("myDir");
            Console.WriteLine(Directory.Exists("myDir"));
            
            //Directory.Delete("myDir");
            string[] files = Directory.GetFiles("myDir");
            foreach (string fileName in files)
            {
                Console.WriteLine(fileName);
            }
            
        }
    }
}