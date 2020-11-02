using System;
using System.IO;

namespace MatrixCalculator
{
    public class MatrixOperations
    {
        /// <summary>
        /// This method generates a new matrix using different arrIn methods - random, user, and file.
        /// </summary>
        /// <param name="method">This the methods that the user would like to use.</param>
        /// <param name="matrix">The output matrix</param>
        /// <param name="n">The number of rows of the array.</param>
        /// <param name="m">The number of columns of the array.</param>
        public static void Enter(string method, out int[,] matrix, out int n, out int m)
        {
            n = 0;
            m = 0;
            matrix = null;
            Random random = new Random();

            switch (method)
            {
                case "random":
                    EnterSize(out n, out m);
                    matrix = new int[n, m];
                    //Array is filled with random number from -1000 to 1000.
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            matrix[i, j] = random.Next(-1000, 1000);
                        }
                    }
                    Console.WriteLine("Matrix has been generated successfully!");
                    Print(matrix, n, m);
                    break;
                case "user":
                    EnterSize(out n, out m);
                    matrix = new int[n, m];
                    string[] input = new string[n];
                    bool repeat;

                    do
                    {
                        Console.WriteLine(@"Enter the elements of the array, separated by a space.
A new line indicates the next row");
                        repeat = false;
                        //User arrIn is taken.
                        for (int i = 0; i < n; i++)
                        {
                            input[i] = Console.ReadLine();
                        }

                        //User arrIn is checked and stored if correct.
                        for (int i = 0; i < n; i++)
                        {
                            int j = 0;
                            foreach (string number in input[i].Split(" "))
                            {
                                try
                                {
                                    matrix[i, j] = int.Parse(number);
                                    j++;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    repeat = true;
                                }
                            }
                        }
                    } while (repeat);

                    break;
                case "file":
                    //TODO: Check is it works
                    EnterSize(out n, out m);
                    matrix = new int[n, m];
                    string[] input2 = new string[n];
                    bool flag = true;
                    Console.Write("Enter file location and name: ");
                    string path = Console.ReadLine();
                    try
                    {
                        input2 = File.ReadAllLines(path);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    if (File.Exists(path) && input2.Length == n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            int j = 0;
                            foreach (string number in input2[i].Split(" "))
                            {
                                try
                                {
                                    matrix[i, j] = int.Parse(number);
                                    j++;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    flag = false;
                                }
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("There has been an error while trying the generate a new matrix.");
                    break;
            }
        }

        /// <summary>
        /// This method prints out a two-dimensional array. It is used for debugging purposes as well as
        /// for improving the interface of the program.
        /// </summary>
        /// <param name="arr">A two-dimensional array</param>
        /// <param name="n">The number of rows of the array.</param>
        /// <param name="m">The number of columns of the array.</param>
        public static void Print(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method gets the size of the array that is about to be created.
        /// </summary>
        /// <param name="n">The number of rows of the array.</param>
        /// <param name="m">The number of columns of the array.</param>
        private static void EnterSize(out int n, out int m)
        {
            Console.WriteLine(@"You are about to create a matrix with sied n x m.
Keep in mind that the matrix can't be bigger than 10x10.");
            do
            {
                Console.Write("n=");
            } while (!int.TryParse(Console.ReadLine(), out n) && n > 0 && n <= 10);

            do
            {
                Console.Write("m=");
            } while (!int.TryParse(Console.ReadLine(), out m) && m > 0 && m <= 10);
        }
        
        /// <summary>
        /// This method determined the sign of a given element.
        /// </summary>
        /// <param name="n">The row of the element</param>
        /// <param name="m">The row of the element</param>
        /// <returns></returns>
        static int ElementSign(int n, int m)
        {
            if ((n + m) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        
        
        /// <summary>
        /// This method created the smaller (child) matrix of a given element.
        /// </summary>
        /// <param name="matrix">The given matrix</param>
        /// <param name="n">The number of rows in the given matrix</param>
        /// <param name="m">The number of columns in the given matrix</param>
        /// <returns></returns>
        static int[,] CreateSmallerMatrix(int[,] matrix, int n, int m)
        {
            int order = int.Parse(System.Math.Sqrt(matrix.Length).ToString());
            int[,] output = new int[order - 1, order - 1];
            int x = 0, y = 0;
            for (int i = 0; i < order; i++, x++)
            {
                if (i != n)
                {
                    y = 0;
                    for (int j = 0; j < order; j++)
                    {
                        if (j != m)
                        {
                            output[x, y] = matrix[i, j];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        
        /// <summary>
        /// This method calculates the determinant of the matrix.
        /// </summary>
        /// <param name="arrIn">The given matrix.</param>
        /// <returns></returns>
        public static int Determinant(int[,] arrIn)
        {
            int order = int.Parse(System.Math.Sqrt(arrIn.Length).ToString());
            if (order > 2)
            {
                int value = 0;
                for (int j = 0; j < order; j++)
                {
                    int[,] arrTwo = CreateSmallerMatrix(arrIn, 0, j);
                    value = value + arrIn[0, j] * (ElementSign(0, j) * Determinant(arrTwo));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((arrIn[0, 0] * arrIn[1, 1]) - (arrIn[1, 0] * arrIn[0, 1]));
            }
            else
            {
                return (arrIn[0, 0]);
            }
        }
    }
}