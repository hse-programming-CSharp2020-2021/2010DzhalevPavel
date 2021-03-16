using System;

namespace Task01
{
    interface IFIgure
    {
        // Interfaces always have public methods
        double Area();
    }

    class Square:IFIgure
    {
        public double Side { get; set; }
        public double Area()
        {
            return Side * Side;
        }

        public Square(double s)
        {
            Side = s;
        }
    }

    class Circle:IFIgure
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public Circle(double r)
        {
            Radius = r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFIgure[] fIgures = new IFIgure[]
            {
                new Circle(10),
                new Circle(2),
                new Square(34),
                new Square(1)
            };

            Print(fIgures);
            
        }

        public static void Print<T>(T[] figures) where T : IFIgure
        {
            foreach (var figure in figures)
            {
                if(figure.Area()>100)
                    Console.WriteLine($"Figure of type {figure.GetType()} and an area of {figure.Area()}");
            }
        }
    }
}