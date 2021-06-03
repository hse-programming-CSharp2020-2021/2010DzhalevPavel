using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SyncDictionary
{
    class Program
    {
        private const int RUNS = 1_000;
        static readonly ConcurrentDictionary<int, int> dictionary = new ();
        static void Add()
        {
            for (var i = 0; i < RUNS; ++i)
            {
                if (dictionary.TryAdd(i, i))
                {
                    Console.WriteLine(i + " was added");
                }
            }
        }
        static void Main(string[] args)
        {
            Task t = Task.WhenAll(
                Task.Run(() => Add()),
                Task.Run(() => Add()),
                Task.Run(() => Add()),
                Task.Run(() => Add()),
                Task.Run(() => Add()));
            t.Wait();
            Console.WriteLine($"Total number of elements:{dictionary.Count}");
        }
    }
}