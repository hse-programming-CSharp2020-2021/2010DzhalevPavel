using System;

namespace CW
{
    class Program
    {
        class Triangle
        {
            private double _a;
            private double _b;
            private double _c;

            public double B
            {
                get => _b;
                set => _b = value;
            }

            public double A
            {
                get => _a;
                set => _a = value;
            }

            public double C
            {
                get => _c;
                set => _c = value;
            }

            public double CalcDist(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
            }

            public Triangle()
            {
                A = 1;
                B = 2;
                C = 3;
            }

            public Triangle(Point a, Point b, Point c)
            {
                A = CalcDist(b, c);
                B = CalcDist(a, c);
                C = CalcDist(b, a);
            }

            public double Perimeter => A + B + C;
            public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter - A) * (Perimeter - B) * (Perimeter - C));
        }

        class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter coordinates of point A: ");
            var a = InPoint(Console.ReadLine());
            Console.Write("Enter coordinates of point B: ");
            var b = InPoint(Console.ReadLine());
            Console.Write("Enter coordinates of point C: ");
            var c = InPoint(Console.ReadLine());

            var triangle = new Triangle(a, b, c);

            Console.WriteLine($"The perimeter of your triangle is {triangle.Perimeter:F3}");
            Console.WriteLine($"The area of your triangle is {triangle.Area:F3}");

            static Point InPoint(string input)
            {
                string[] inp = input.Split(' ');
                var result = new Point();
                try
                {
                    result.X = double.Parse(inp[0]);
                    result.Y = double.Parse(inp[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return result;
            }
        }
    }
}