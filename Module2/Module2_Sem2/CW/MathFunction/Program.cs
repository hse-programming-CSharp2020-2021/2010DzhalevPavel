using System;

namespace MathFunction
{
    class Program
    {
        class Sin
        {
            private double min;
            private double max;

            public double Min
            {
                get => min;
                set => value = min;
            }
            public double Max
            {
                get => max;
                set => value = max;
            }

            public double this[int x] => (x>=min&&x<=max)?Math.Sin(x):0;

            public Sin(double max, double min)
            {
                this.min = min;
                this.max = max;
            }
        }
        static void Main(string[] args)
        {
            Sin sin = new Sin(Math.PI,0);
            Console.WriteLine($"{sin[2]}");
        }
    }
}