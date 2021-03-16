using System;

namespace Task1
{
    interface ICalculation
    {
        double Perform(double a);
    }

    class Add
    {
        private double c;

        public Add(double c)
        {
            this.c = c;
        }

        public double Perform(double a)
        {
            return a + c;
        }
    }

    class Multiply : ICalculation
    {
        private double c;

        public Multiply(double c)
        {
            this.c = c;
        }

        public double Perform(double a)
        {
            return a * c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double n = 10;
            var A = new Add(5);
            var M = new Multiply(10);
            Calculate(n, A, M);
            
        }

        static void Calculate(double n, Add a, Multiply m)
        {
            Console.WriteLine($"The original number is {n} \n" +
                              $"After the Add(): {a.Perform(n)}\n" +
                              $"After Multiply(): {m.Perform(n)}");
        }
    }
}