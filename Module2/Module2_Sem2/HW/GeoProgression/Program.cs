using System;

namespace Task01
{
    internal static class Program
    {
        //By default classes are created as internal
        class GeoProgression
        {
            private double _start;
            private double _increment;

            public double Start
            {
                get => _start;
                set => _start = value;
            }
            public double Increment
            {
                get => _increment;
                set => _increment = value;
            }

            public GeoProgression()
            {
                _start = 0;
                _increment = 1;
            }
            public GeoProgression(double start, double increment)
            {
                Start = start;
                Increment = increment;
            }

            public double this[int index] => _start * Math.Pow(_increment,index);

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