using System;

namespace Task01
{
    internal static class Program
    {
        //By default classes are created as internal
        class GeoProgression
        {
            private int a0;
            private int r;

            public int A0
            {
                get => a0;
                set => a0 = value;
            }
            public int R
            {
                get => r;
                set => r = value;
            }

            public GeoProgression(int a0, int r)
            {
                A0 = a0;
                R = r;
            }

            public double this[int index] => a0 * Math.Pow(r,index);

            public double Sum(int n)
            {
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += this[i];
                }
                return sum;
            }
        }
        private static void Main(string[] args)
        {
            GeoProgression progression = new GeoProgression(2,3);
            Console.WriteLine(progression[0]);
            Console.WriteLine(progression[1]);
            Console.WriteLine(progression[2]);
            Console.WriteLine(progression[3]);
            Console.WriteLine(progression.Sum(3));

        }
    }
}