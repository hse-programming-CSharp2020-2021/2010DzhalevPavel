using System;

namespace AdditionalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do
            {
                Console.Write("n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            int[,] a = new int[n, n];

            int c = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[j, i] = c;
                    c++;
                }
            }

            Print(a, n);
            Console.WriteLine();

            int[,] b=new int[n,n];
            c = 1;
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == sum)
                    {
                        if (sum % 2 == 1&&j==0)
                        {
                            i=i-1;
                        }
                        b[i, j] = c;
                        c++;
                        
                        
                        counter++;
                        if (counter == sum + 1)
                        {
                            counter = 0;
                            sum++;
                        }
                    }
                }
            }
            
            Print(b,n);

            //Prints the array.
            void Print(int[,] array, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}