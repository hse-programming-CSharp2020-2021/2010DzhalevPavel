using System;

namespace MatrixCalculator
{
    class Program
    {
        /// <summary>
        /// This is the core file of the program, which redirects to all its functionalities.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Type ""help"" to view all available commands");

            //I am doing a final check for any exceptions in order to make sure that the program will run as smooth as possible.
            try
            {
                do
                {
                    //Calling the main method from the Switcher.cs file.
                    CommandsManager.SelectCommand();
                    Console.Write(
                        "In order to exit the program, press Esc. In order to continue, press any other key...");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}