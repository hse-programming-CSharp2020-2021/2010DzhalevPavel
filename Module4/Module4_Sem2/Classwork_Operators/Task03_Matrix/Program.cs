using System;
using System.Diagnostics.Contracts;

namespace Task03_Matrix
{
    class Matrix2
    {
        private double[,] matrix = new double[2,2];

        //Constructor with 4 params.
        public Matrix2(double a11, double a12, double a21, double a22)
        {
            matrix[0, 0] = a11;
            matrix[0, 1] = a12;
            matrix[1, 0] = a21;
            matrix[1, 1] = a22;
        }

        //Constructor with 2 params.
        public Matrix2(double a11, double a22)
        {
            matrix[0, 0] = a11;
            matrix[1, 1] = a22;
            matrix[0, 1] = matrix[1, 0] = 0;
        }
        
        //Copy constructor
        public Matrix2(Matrix2 example)
        {
            matrix = example.matrix;
        }

        //Returns the determinant of the matrix;
        public double Det()
        {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1,
             0];
            return det;
        }
        
        //Returns the inversed matrix
        public Matrix2 Inverse()
        {
            var transposed = Transpose();
            return transposed/Det();
        }

        //Returns the transposed matrix
        public Matrix2 Transpose()
        {
            var transposed = new Matrix2(
                matrix[0,0],
                matrix[1,0], 
                matrix[0,1], 
                matrix[1,1]);
            return transposed;
        }

        public static Matrix2 operator +(Matrix2 a, Matrix2 b)
        {
            Matrix2 result = new Matrix2(
                a.matrix[0,0] + b.matrix[0,0],
                a.matrix[0,1] + b.matrix[0,1],
                a.matrix[1,0] + b.matrix[1,1],
                a.matrix[1,0] + b.matrix[1,1]
            );
            return result;
        }
        
        public static Matrix2 operator -(Matrix2 a, Matrix2 b)
        {
            Matrix2 result = new Matrix2(
                a.matrix[0,0] - b.matrix[0,0],
                a.matrix[0,1] - b.matrix[0,1],
                a.matrix[1,0] - b.matrix[1,1],
                a.matrix[1,0] - b.matrix[1,1]
            );
            return result;
        }
        
        public static Matrix2 operator /(Matrix2 a, double b)
        {
            Matrix2 result = new Matrix2(
                a.matrix[0,0] /b,
                a.matrix[0,1] /b,
                a.matrix[1,0] /b,
                a.matrix[1,0] /b
            );
            return result;
        }
        
        public static Matrix2 operator *(Matrix2 a, Matrix2 b)
        {
            Matrix2 result = new Matrix2(
                a.matrix[0,0] * b.matrix[0,0] + a.matrix[0,1] * b.matrix[1,0],
                a.matrix[0,0] * b.matrix[0,1] + a.matrix[0,1] * b.matrix[1,1],
                a.matrix[1,0] * b.matrix[0,1] + a.matrix[1,1] * b.matrix[1,0],
                a.matrix[1,1] * b.matrix[0,1] + a.matrix[1,1] * b.matrix[1,1]
            );
            return result;
        }
        
        public static Matrix2 operator *(Matrix2 a, double b)
        {
            Matrix2 result = new Matrix2(
                a.matrix[0,0] *b,
                a.matrix[0,1] *b,
                a.matrix[1,0] *b,
                a.matrix[1,0] *b
            );
            return result;
        }
        
        public static Matrix2 operator /(Matrix2 a, Matrix2 b)
        {
            Matrix2 result = a * b.Inverse();
            return result;
        }
        

        public override string ToString()
        {
            return $"{matrix[0, 0]} {matrix[0, 1]}\n" +
                   $"{matrix[1, 0]} {matrix[1, 1]}\n";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Matrix2(1, 2, 3, 4);
            Console.WriteLine(a);
            Console.WriteLine($"Determinant: {a.Det()}");
            Console.WriteLine(a.Transpose());
            Console.WriteLine(a.Inverse());
        }
    }
}