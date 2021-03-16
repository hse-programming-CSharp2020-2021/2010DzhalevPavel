using System;

namespace Task2
{
    interface ISequence
    {
        double GetElement(int pos);
    }

    class ArithmeticProgression : ISequence
    {
        private double first;
        private double addition;
        public ArithmeticProgression(double first, double addition)
        {
            this.first = first;
            this.addition = addition;
        }
        public double GetElement(int pos)
        {
            return first + (pos - 1) * addition;
        }
    }

    class GeometricProgression : ISequence
    {
        private double first;
        private double multiplyer;
        public GeometricProgression(double first, double multiplyer)
        {
            this.first = first;
            this.multiplyer = multiplyer;
        }
        
        public double GetElement(int pos)
        {
            return first * Math.Pow(multiplyer, pos-1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum (new GeometricProgression(2, 2), 3));
        }

        static double Sum(ISequence s, int elements)
        {
            double sum =0;
            for (int i = 1; i <= elements; i++)
            {
                sum += s.GetElement(i);
            }

            return sum;
        }
    }
}