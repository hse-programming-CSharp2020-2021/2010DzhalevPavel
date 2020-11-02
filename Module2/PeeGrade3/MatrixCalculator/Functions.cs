using System;

namespace MatrixCalculator
{
    public class Functions
    {
        //Global error message is stored in a variable for easy access.
        static string functionsError =
            @"Something went wrong! Please check spelling again or press ""help"" to see all commands...";

        /// <summary>
        /// This functions prints all instructions of the porgram.
        /// </summary>
        public static void Help()
        {
            Console.WriteLine(@"Type ""principal"" to calculate the sum of all elements on the main diagonal
Type ""transpose"" in order to transpose a matrix.
Type ""add"" to add one matrix to another
Type ""subtract"" to subtract one matrix from another
Type ""multiply-two"" to add one matrix to another
Type ""multiply-by-number"" to multiply a matrix by a number
Type ""det"" to finds the determinant of a matrix");
        }

        /// <summary>
        /// This method is used to exit from the switch cycle in Switcher.cs.
        /// </summary>
        /// <param name="parameters">This array contains all user commands.</param>
        /// <param name="command">This string changes the command string in Switcher.cs in order to exit the cycle</param>
        public static void Exit(string[] parameters, out string command)
        {
            //This is a common check performed in this file. It makes sure that the amount of
            //commands correspond to the number of parameters of the method.
            if (parameters.Length != 1)
            {
                Console.WriteLine(functionsError);
                command = " ";
            }

            else
            {
                Console.WriteLine("Exiting...");
                //This timer is added just to make the program more interesting. It serves no practical purpose.
                System.Threading.Thread.Sleep(2000);
                command = "exit";
            }
        }

        /// <summary>
        /// This method calculates the sum of all elements on the main diagonal.
        /// </summary>
        public static void Principal()
        {
            //Create a matrix.
            MatrixOperations.Enter(InputMethod(), out int[,] arr, out int n, out int m);
            int sum = 0;
            if (n != 0 && m != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (i == j) sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine($"The sum of all elements on the main diagonal is: {sum}.");
        }

        /// <summary>
        /// This method transposes a matrix and prints out the result.
        /// </summary>
        /// <param name="arr">The number of rows of the array.</param>
        /// <param name="n">The columns of rows of the array.</param>
        /// <param name="n"></param>
        public static void Transpose()
        {
            //Create a matrix.
            MatrixOperations.Enter(InputMethod(), out int[,] arr, out int n, out int m);
            int[,] newArray = (int[,]) arr.Clone();
            if (n != 0 && m != 0)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            arr[i, j] = newArray[j, i];
                        }
                    }

                    Console.WriteLine("You have successfully transposed the matrix:");
                    MatrixOperations.Print(arr, n, m);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static string InputMethod()
        {
            string method = "";
            Console.WriteLine(@"Which input method would you like to choose?
Supported methods are: 
""random"" - to generate a matrix with random numbers in the range [-1000;1000]
""user""   - to enter all numbers yourself
""file""   - to read matrix from file");

            do
            {
                Console.Write("Input method: ");
                method = Console.ReadLine();
            } while (!method.Equals("random") && !method.Equals("user") && !method.Equals("file"));

            return method;
        }

        /// <summary>
        /// This method adds two matrices.
        /// </summary>
        public static void AddTwo()
        {
            Console.WriteLine("Enter the first matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix1, out int n1, out int m1);
            Console.WriteLine("Now, enter the second matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix2, out int n2, out int m2);
            int[,] newMatrix = new int[n1, m1];

            if (n1 == n2 && m1 == m2)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m1; j++)
                    {
                        newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                Console.WriteLine("You have successfully added these 2 matrices. The result is:");
                MatrixOperations.Print(newMatrix, n1, m1);
            }
            else
            {
                Console.WriteLine("The size of these matrices differ and they cannot be added.");
            }
        }

        /// <summary>
        /// This method subtracts two matrices.
        /// </summary>
        public static void SubtractTwo()
        {
            Console.WriteLine("Enter the first matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix1, out int n1, out int m1);
            Console.WriteLine("Now, enter the second matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix2, out int n2, out int m2);
            int[,] newMatrix = new int[n1, m1];

            if (n1 == n2 && m1 == m2)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m1; j++)
                    {
                        newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }

                Console.WriteLine("You have successfully subtracted these 2 matrices. The result is:");
                MatrixOperations.Print(newMatrix, n1, m1);
            }
            else
            {
                Console.WriteLine("The size of these matrices differ and they cannot be added.");
            }
        }

        /// <summary>
        /// This method multiplies two matrices.
        /// </summary>
        public static void MultiplyTwo()
        {
            Console.WriteLine("Enter the first matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix1, out int n1, out int m1);
            Console.WriteLine("Now, enter the second matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix2, out int n2, out int m2);
            int[,] newMatrix = new int[n1, m1];

            //TODO: Implement multiplication.
            if (m1 == n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m1; j++)
                    {
                        newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }
                Console.WriteLine("You have successfully multiplied these 2 matrices. The result is:");
                MatrixOperations.Print(newMatrix, n1, m1);
            }
            else
            {
                Console.WriteLine("The size of these matrices differ and they cannot be added.");
            }
        }

        /// <summary>
        /// This method multiplies a matrix by a given number.
        /// </summary>
        public static void MultiplyByNumber()
        {
            int number;
            Console.WriteLine("Enter the first matrix:");
            MatrixOperations.Enter(InputMethod(), out int[,] matrix, out int n, out int m);
            do
            {
                Console.WriteLine("Enter the number that you would like to use: ");
            } while (!int.TryParse(Console.ReadLine(), out number));

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = matrix[i, j] * number;
                }
            }
            Console.WriteLine($"You have successfully multiplied the matrix by {number}. The result is:");
            MatrixOperations.Print(matrix, n, m);
        }
        
        /// <summary>
        /// This method finds the determinant of a matrix.
        /// </summary>
        public static void Det()
        {
            MatrixOperations.Enter(InputMethod(), out int[,] matrix, out int n, out int m);
            Console.WriteLine($"The determinant of this matrix is: {MatrixOperations.Determinant(matrix)}");
            
        }
    }
}