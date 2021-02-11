using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01
{
    class Program
    {
        /*
           Вводится число (желательно 4-х или 5-х значное).
           Вернуть и вывести на экран коллекцию из цифр этого числа в
           порядке от старших разрядов к младшим
           123456
           1  2  3  4  5  6
           1) linkedList
           2) stack
            */
        static void Main(string[] args)
        {
            OrderWithList();
            OrderWithStack();
            Console.ReadKey();
            
        }

        public static void OrderWithList()
        {
            int n = int.Parse(Console.ReadLine());

            var digits = new LinkedList<int>();
            foreach (var number in n.ToString())
            {
                digits.AddLast(int.Parse(number.ToString()));
            }

            foreach (var v in digits)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }

        public static void OrderWithStack()
        {
            int n = int.Parse(Console.ReadLine());

            var digits = new Stack<int>();
            foreach (var number in n.ToString())
            {
                digits.Push(int.Parse(number.ToString()));
            }
            
            foreach (var v in digits)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
    }
}