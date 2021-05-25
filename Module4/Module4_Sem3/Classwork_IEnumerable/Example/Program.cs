using System;
using System.Collections;
using System.Collections.Generic;
 
 
namespace Task_4
{​​​​​​​
    class Colors : IEnumerable<string>
    {​​​​​​​
        string[] colors = {​​​​​​​ "red", "green", "blue" }​​​​​​​;
 
 
        public IEnumerator<string> GetEnumerator()
        {​​​​​​​
            return new ColorsEnumerator(colors);
        }​​​​​​​
 
 
        IEnumerator IEnumerable.GetEnumerator()
        {​​​​​​​
            throw new NotImplementedException();
        }​​​​​​​
 
 
        private class ColorsEnumerator : IEnumerator<string>
        {​​​​​​​
            int position = -1;
            readonly string[] c;
 
 
            public ColorsEnumerator(string[] c)
            {​​​​​​​
                this.c = c;
            }​​​​​​​
            public string Current
            {​​​​​​​
                get
                {​​​​​​​
                    c[position] += 1;
                    return c[position];
                }​​​​​​​
            }​​​​​​​
 
 
            object IEnumerator.Current => throw new NotImplementedException();
 
 
            public bool MoveNext()
            {​​​​​​​
                return ++position < c.Length;
            }​​​​​​​
 
            public void Reset()
            {​​​​​​​
                position = -1;
            }​​​​​​​
 
 
            public void Dispose()
            {​​​​​​​
            }​​​​​​​
        }​​​​​​​
    }​​​​​​​
 
 
    /*
     public interface IEnumerable
        {​​​​​​​
            IEnumerator GetEnumerator();
        }​​​​​​​
 
 
 
    public interface IEnumerator
    {​​​​​​​
        bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
        object Current {​​​​​​​get;}​​​​​​​  // текущий элемент в контейнере
        void Reset(); // перемещение в начало контейнера
    }​​​​​​​
     */
 
 
    class Program
    {​​​​​​​
        static void Main(string[] args)
        {​​​​​​​
            int[] a = {​​​​​​​ 1, 2, 3, 4, 5 }​​​​​​​;
 
 
            //foreach (int i in a)
            //    Console.WriteLine(i);
 
 
            IEnumerator ie = a.GetEnumerator();
 
 
            while (ie.MoveNext())
            {​​​​​​​
                Console.WriteLine(ie.Current);
            }​​​​​​​
 
 
            Colors colors = new Colors();
 
 
            foreach (var i in colors)
                Console.WriteLine(i);
 
 
            foreach (var i in colors)
                Console.WriteLine(i);
 
 
            foreach (var i in colors)
                Console.WriteLine(i);
        }​​​​​​​
    }​​​​​​​
}​​​​​​​