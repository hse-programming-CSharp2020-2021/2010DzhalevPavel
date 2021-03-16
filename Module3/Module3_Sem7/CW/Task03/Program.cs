using System;
using System.Collections.Generic;

// ReSharper disable CommentTypo

namespace Task03
{
    /*Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
     Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива, 
     получения элемента из массива по индексу и метод, возвращающий длину массива.
     Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления*/

    class MyClass<T>
    {
        private List<T> array = new List<T>();

        public void Add(T o)
        {
            array.Add(o);
        }
        public void Delete(T o)
        {
            array.Remove(o);
        }

        public T this[int index] => array[index];

        public void Length()
        {
            Console.WriteLine($"The array has a length of: {array.Count}");
        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ar = new MyClass<string>();
            
            ar.Add("John");
            ar.Print();
            ar.Length();
            ar.Add("Ivan the Terrible");
            ar.Print();

        }
    }
}