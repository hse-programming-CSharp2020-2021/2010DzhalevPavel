using System;
using System.Reflection.Metadata.Ecma335;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IFunction
    {
        double Function(double n);
    }

    class F : IFunction
    {

        public double Function(double n)
        {
            throw new NotImplementedException();
        }
    }

    class G
    {
        private F first;
        private F second;

        public double GF(double x0)
        {
            return first.Function(second.Function(x0));
        }

    }
}