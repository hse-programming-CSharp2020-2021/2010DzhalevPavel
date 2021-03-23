using System;
using System.Collections.Generic;
using System.IO;

namespace Rectangles
{
    /*Объявить структуру Rectangle, описывающую прямоугольник, заданный длинами сторон.
     Структура реализует интерфейс IComparable, сравнение структур происходит по величине 
     площади прямоугольника.
Объявить класс Block3D, описывающий «кирпич», заданный основанием и высотой. 
Основание – объект структуры Rectangle. Класс реализует интерфейс IComparable, 
сравнивая кирпичи по величине площади основания.
В основной программе протестировать работу методов классов, отсортировав массив элементов типа 
Block3D. Записать его в файл, а затем восстановить из файла и вывести на экран.*/

    struct Rectangle : IComparable
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Area
        {
            get => A * B;
        }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Rectangle otherRect = obj is Rectangle ? (Rectangle) obj : default;
            if (Area > otherRect.Area) return 1;
            if (Area == otherRect.Area) return 0;
            else return -1;
        }
    }

    class Block3D : IComparable
    {
        public Rectangle Base { get; set; }
        public double Height { get; set; }

        public Block3D(Rectangle b, double height)
        {
            Base = b;
            Height = height;
        }
        public int CompareTo(object? obj)
        {
            var otherBlock = obj as Block3D;
            if (Base.Area < otherBlock.Base.Area) return -1;
            if (Base.Area == otherBlock.Base.Area) return 0;
            return 1;
        }

        public override string ToString()
        {
            return
                $"This is a block with Rectangle area {Base.Area} and height: {Height}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Block3D>();
            
            list.Add(new Block3D(new Rectangle(2, 3), 10));
            list.Add(new Block3D(new Rectangle(4, 6), 14));
            list.Add(new Block3D(new Rectangle(5, 3), 40));

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            
            list.Sort();
            
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            //Write
            using (var sw = new StreamWriter(File.Create("output.txt")))
            {
                foreach (var i in list)
                {
                 sw.WriteLine($"{i.Base.A} {i.Base.B} {i.Height}");   
                }
            }
            
            //Read
            using (var sr = new StreamReader(File.Open("output.txt", FileMode.Open)))
            {
                var newList = new List<Block3D>();
                while (!sr.EndOfStream)
                {
                    var item = sr.ReadLine().Split(" ");
                    newList.Add(new Block3D(new Rectangle(double.Parse(item[0]), 
                        double.Parse(item[1])), 
                        double.Parse(item[2])));
                }

                foreach (var i in newList)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}