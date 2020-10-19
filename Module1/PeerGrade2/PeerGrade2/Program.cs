using System;
using System.ComponentModel;
using System.IO;

namespace PeerGrade2
{
    public class Program
    {
        /// <summary>
        /// This is the core file of the program, which redirects to all its functionalities.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //I am doing a final check for any exceptions in order to make sure that the program will run as smooth as possible.
            try
            {
                do
                {
                    //Calling the main method from the Switcher.cs file.
                    Switcher.SelectCommand();
                    Console.Write("In order to exit the program, press Esc. In order to continue, press any other key...");
                } while (Console.ReadKey(true).Key!=ConsoleKey.Escape);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}