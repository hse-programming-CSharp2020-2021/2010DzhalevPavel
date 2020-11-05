using System;

namespace Task01
{
    internal static class Program
    {
        //By default classes are created as internal
        class ArProgression
        {
            private int a0;
            private int d;

            public int A0
            {
                get
                {
                    return a0;
                }
                set
                {
                    a0 = value;
                }
            }
            public int D
            {
                get
                {
                    return d;
                }
                set
                {
                    d = value;
                }
            }

            public ArProgression(int a0, int d)
            {
                A0 = a0;
                D = d;
            }

            public int this[int index]
            {
                get
                {
                    return a0 + d * index;
                }
                set
                {
                    
                }
            }
        }
        private static void Main(string[] args)
        {
            ArProgression progression = new ArProgression(2,3);
            Console.WriteLine(progression[0]);
            Console.WriteLine(progression[1]);
            Console.WriteLine(progression[2]);
            Console.WriteLine(progression[3]);

        }
    }
}