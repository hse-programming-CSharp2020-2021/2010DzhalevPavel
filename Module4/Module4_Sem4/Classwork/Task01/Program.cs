using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualBasic;

namespace Task01
{
    /*В некоторой̆ коллекции хранятся целые числа.
    1. Составить LINQ-выражение, формирующее коллекцию их квадратов.           
    2. Составить LINQ- выражение, выбирающее только положительные двузначные числа.
    3. Составить LINQ- выражение, выбирающее только чётные числа и сортирующее их по убыванию.
    4. Составить LINQ- выражение, группирующее числа по порядку (сотни, десятки, единицы)
    Написать программу, применяющую выражения к коллекции из n (задать с клавиатуры) случайных чисел из отрезка [-1000, 1000]. (снабдить выводом исходных чисел и сформированных коллекций). Сделать с помощью стандартных операторов и с помощью методов расширения.*/
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) && n>0);

            var rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-1000, 1000);
            }

            var squares =
                from a in array
                select a * a;
            var posDoubDig =
                from a in array
                where a.ToString().Length == 2 && a>0
                select a;
            var even =
                from a in array
                where a%2 == 0
                orderby a descending 
                select a;
            var length =
                from a in array
                orderby a.ToString().Length 
                select a;
            
            Print(array, "First array");
            Print(squares, "Squared values");
            Print(posDoubDig, "Positive numbers with two digits only");
            Print(even, "Sorted even numbers");
            Print(length, "Sorted by length elements");
            
        }

        static void Print<T>(T col, string message) where T : IEnumerable
        {
            Console.WriteLine($"{message}:");
            
            //Is the collection empty
            /*if ()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Collection is empty.");
                Console.BackgroundColor = default;
            }*/
            
            foreach (var item in col)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        } 
    }
}