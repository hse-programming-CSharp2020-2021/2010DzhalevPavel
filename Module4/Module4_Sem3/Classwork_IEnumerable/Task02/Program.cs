using System;
using System.Collections;
using System.Collections.Generic;

namespace Task02
{
    /*Задача 3.
    Определить класс LucasCollection, реализующий коллекцию из n чисел Люка. Класс LucasCollection реализует интерфейс IEnumerable<int>. Необходимо предоставить возможность обходить элементы коллекции через foreach. Для того, чтобы это было возможно, необходимо определить закрытый класс LucasCollectionEnumerator, реализующий доступ к отдельным элементам коллекции (реализует интерфейс IEnumerator<int>).  Класс LucasCollection должен использовать не встроенный перечислитель, а LucasCollection Enumerator, который реализует IEnumerator<int>.
    Создать программу, которая получает на вход число n – количество чисел Люка в последовательности LucasCollection. С помощью оператора foreach вывести последовательность на экран
    */
    class LucasCollection : IEnumerable<int>
    {
        public int[] collection { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class LucasCollectionEnumerator : IEnumerator<int>
    {
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public int Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            var luCol = new LucasCollection(n);
            foreach (var number in luCol)
            {
                Console.Write($"{number} ");
            }
        }
    }
}