using System;

namespace Figures
{
    class Program
    {
        class Point
        {
            private int x = 1;
            private int y = 1;
            
            public virtual string Display()
            {
                return $"This is a point with coordinates X: {x} and Y{y}";
            }

            public virtual double Area => 0;
        }

        class Circle : Point
        {
            private double rad;

            public double Rad
            {
                get => rad;
                set
                {
                    if(rad<0)
                        throw new ArgumentException("Side cannot be less than 0");
                    rad = value;
                }
            }

            public Circle(int x, int y)
            {
                rad = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }

            public override double Area => Math.PI*rad*rad;

            public double Len => 2 * Math.PI * rad;

            public override string Display()
            {
                return $"This is a circle with area {Area:f2} and length {Len:f2}";
            }
        }

        class Square : Point
        {
            private double side;

            public double Side
            {
                get => side;
                set
                {
                    if(side<0)
                        throw new ArgumentException("Side cannot be less than 0");
                    side = value;
                }
            }

            public Square(int x, int y)
            {
                side = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            }

            public override string Display()
            {
                return $"This is a square with side {side:f2}, area {Area:f2}, and length {Len:f2}";
            }

            public override double Area => side * side;

            public double Len => 4 * side;
        }
        static void Main(string[] args)
        {
            var p = new Point();
            var c = new Circle(2,3);
            var s = new Square(2,3);
            
            Console.WriteLine(p.Display());
            Console.WriteLine(c.Display());
            Console.WriteLine(s.Display());
            
            Point link = null;
            link = new Point();
            Console.WriteLine(link.Display());
            link = new Circle(4,5);
            Console.WriteLine(link.Display());
            link = new Square(3,4);
            Console.WriteLine(link.Display());
        }
        
    }
}