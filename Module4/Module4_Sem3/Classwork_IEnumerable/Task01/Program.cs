using System;
using System.Collections;
using System.Collections.Generic;

namespace Task01
{
    class RandomCollection : IEnumerable<int>
    {
        public int[] Collection { get; set; }

        public RandomCollection(int arraySize)
        {
            try
            {
                Collection = new int[arraySize];

                var rand = new Random();
                for (int i = 0; i < arraySize; i++)
                {
                    Collection[i] = rand.Next(0, 100);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new RandomEnumerator(Collection);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class RandomEnumerator : IEnumerator<int>
    {
        private readonly int[] array;
        private int _current;

        public RandomEnumerator(int[] array)
        {
            this.array = array;
        }

        public bool MoveNext()
        {
            if (_current < array.Length)
            {
                _current++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            if (array.Length > 0)
                _current = 0;
        }

        int IEnumerator<int>.Current => _current;

        public object Current { get; }
        public void Dispose()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var randCollection = new RandomCollection(10);

            foreach (var number in randCollection.Collection)
            {
                Console.WriteLine($"{number} ");
            }
        }
    }
}