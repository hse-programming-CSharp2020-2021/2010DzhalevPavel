using System;

namespace Task03
{
    internal class Program
    {
        static bool Triangle(double x, double y, double z, out double p, out double s)
        {
            bool exists = false;
            p = 0;
            s = 0;

            if (x + y > z && z + y > x && z + x > y)
            {
                p = x + y + z;
                s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                exists = true;
            }
            return exists;
        }
        public static void Main(string[] args)
        {

         double a,b,c;
         do Console.Write("Enter a:");
         while (!double.TryParse(Console.ReadLine(), out a)|a<0);
         do Console.Write("Enter b:");
         while (!double.TryParse(Console.ReadLine(), out b)|b<0);
         do Console.Write("Enter c:");
         while (!double.TryParse(Console.ReadLine(), out c)|c<0);
         
    
         Console.WriteLine(Program.Triangle(a,b,c, out double p, out double s));
         Console.WriteLine($"Perimeter is: {p}");
         Console.WriteLine($"Area is: {s}");
        }
    }
}