using System;
using System.Collections.Generic;
using System.Data.Common;

namespace LinkedLIsts
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new LinkedList();
                a.Add(34);
                a.Add(234);
                a.Add(54);
                a.Add(33);
                a.Add(3);
                a.Print();

                a.Clear();
                a.Add(-234);
                a.Add(-12);
                a.Add(43);
                a.Add(3);
                a.Add(54500);
                a.Print();

                a.AddFirst(5);
                a.Print();

                Console.WriteLine($"Our list contains 5: {a.Contains(5)}");

                a.Reverse();
                a.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            //Next actually does a recursive call 
            return $"{Data}";
        }
    }

    class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(int data)
        {
            Node node = new Node(data);

            if (Head == null)
                Head = node;
            else 
                Tail.Next = node;
            Tail = node;

            Count++;
        }

        public void Print()
        {
            Node current = Head;

            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        
        public bool Contains(int data)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Data == data)
                    return true;
                current = current.Next;
            }

            return false;
        }
        
        public void AddFirst(int data)
        {
            if (Count == 0)
            {
                Add(data);
            }
            var oldNode = Head;
            Head = new Node(data);
            Head.Next = oldNode;
            Count++;
        }
        
        /// <summary>
        /// Finds the element with max Data field.
        /// </summary>
        /// <returns></returns>
        public Node Max()
        {
            Node current = Head;
            Node max = current;

            while (current != null)
            {
                if (current.Data >= max.Data)
                    max = current;
            }

            return max;
        }

        public void Remove(int data)
        {
            Node current = Head;
            Node prev = null;
            while (current != null)
            {
                if (current.Data == data)
                {
                    prev.Next = current.Next;
                    if (current.Next == null)
                        Tail = prev;
                    else
                    {
                        Head = Head.Next;
                    }

                    if (Head == null)
                    {
                        Tail = null;
                    }
                    Count--;
                }
                

                prev = current;
                current = current.Next;
            }
        }

        public void Reverse()
        {
            if (Count > 0)
            {
                Stack<Node> stack = new Stack<Node>();

                Node current = Head;

                while (current != null)
                {
                    stack.Push(current);
                    current = current.Next;
                }
                Tail = Head;
                Head.Next = null;
                Head = stack.Pop();
                current = Head;
                while (stack.Count != 0)
                {
                    current.Next = stack.Pop();
                    current = current.Next;
                }
            }
            else throw new Exception("Cannot reverse list if it is empty.");
        }
    }
}