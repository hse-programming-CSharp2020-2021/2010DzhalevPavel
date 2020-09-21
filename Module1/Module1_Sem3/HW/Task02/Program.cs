using System;

namespace Task02
{
    internal class Program
    {
        public static int ReOrder(int a)
        {
            int r,sum=0;
            for(int t=a;t!=0;t=t/10)
            {
                r=t % 10;
                sum=sum*10+r;
            }
            return sum;

        }
        public static void Main(string[] args)
        {
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine(Program.ReOrder(a));
        }
    }
}