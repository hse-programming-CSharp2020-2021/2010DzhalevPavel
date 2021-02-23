using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List
            
            //Double Linked List
            
            //FIFO - First-in-First-out
            Queue<int> _queue = new Queue<int>();
            _queue.Enqueue(9);
            
            //LIFO - Last-int-First-out
            //Be Careful! if you print all elements with foreach, they will be
            //printed from the last one to the first. May result in unexpected behaviour.
            Stack<double> doubles = new Stack<double>();
            doubles.Push(5.643);
            var res = doubles.Pop();
            doubles.Peek();

            //These data structures are used in order to make the process
            //of organizing data faster.


        }
    }
}