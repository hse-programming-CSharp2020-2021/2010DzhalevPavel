using System;

namespace Task01
{
    internal class Program
    {

        static bool Transform(ref uint numb)
        {
            uint a1 = numb % 10;
            uint a2 = (numb % 100) / 10;
            uint a3 = numb / 100;


            uint max, min;
            
            if (a1>a2)
            {
                if (a1 > a2) max = a1;
                else max = a3;
            }else
            {
                if (a2 > a3) max = a2;
                else max = a3;
            }
            if (a1<a2)
            {
                if (a1 <a2) min = a1;
                else min = a3;
            }else
            {
                if (a2 < a3) min = a2;
                else min = a3;
            }

            bool transform = false;

            uint med = a1 + a2 + a3 - min - max;
            
            if (max > med && med > min) transform = true;
            if (transform)
                numb = max * 100 + med * 10 + min;
            return transform;



        }
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            
            Console.WriteLine(Program.Transform (ref n));
            Console.WriteLine(n);
        }
    }
}