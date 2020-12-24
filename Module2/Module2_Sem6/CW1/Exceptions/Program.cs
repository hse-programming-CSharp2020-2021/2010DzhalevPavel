using System;
using System.Runtime.InteropServices;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "";
                Print(s);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(Math.Sqrt(-1));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Random r = null;
                Console.WriteLine(r.Next(0, 10));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Print(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Print(string s)
        {
            Console.WriteLine(s.Substring(1,4));
        }
        
    }
}