using System;
using System.Threading;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(new ThreadStart(Count));
            thread.Start();
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                Thread.Sleep(1000);
            }
        }

        public static void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                Thread.Sleep(1000);
            }
        }
    }
}