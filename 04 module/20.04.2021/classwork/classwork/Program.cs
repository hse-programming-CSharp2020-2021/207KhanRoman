using System;

namespace classwork
{
    class Matrix2
    {
        public double[,] Matrix { get; set; } = new double[2, 2];
        public Matrix2(double a11, double a22)
        {
            Matrix[0, 0] = a11;
            Matrix[1, 1] = a22;
        }
        public Matrix2(double a11, double a12, double a21, double a22)
        {
            Matrix[0, 0] = a11;
            Matrix[0, 1] = a12;
            Matrix[1, 0] = a21;
            Matrix[1, 1] = a22;
        }
        public Matrix2(Matrix2 x)
        {
            Matrix[0, 0] = x.Matrix[0, 0];
            Matrix[0, 1] = x.Matrix[0, 1];
            Matrix[1, 0] = x.Matrix[1, 0];
            Matrix[1, 1] = x.Matrix[1, 1];
        }
        public double Det()
        {
            return Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0];
        }
        public Matrix2 Inverse() => new Matrix2(Matrix[1, 1] / Det(), -Matrix[0, 1] / Det(), -Matrix[1, 0] / Det(), Matrix[0, 0] / Det());
        public Matrix2 Transpose() => new Matrix2(Matrix[0, 0], Matrix[1, 0], Matrix[0, 1], Matrix[1, 1]);

        public static Matrix2 operator +(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.Matrix[0, 0] + b.Matrix[0, 0],
                               a.Matrix[0, 1] + b.Matrix[0, 1],
                               a.Matrix[1, 0] + b.Matrix[1, 0],
                               a.Matrix[1, 1] + b.Matrix[1, 1]);
        }
        public static Matrix2 operator -(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.Matrix[0, 0] - b.Matrix[0, 0],
                               a.Matrix[0, 1] - b.Matrix[0, 1],
                               a.Matrix[1, 0] - b.Matrix[1, 0],
                               a.Matrix[1, 1] - b.Matrix[1, 1]);
        }
        public static Matrix2 operator *(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.Matrix[0, 0] * b.Matrix[0, 0] + a.Matrix[0, 1] * b.Matrix[1, 0],
                               a.Matrix[0, 0] * b.Matrix[0, 1] + a.Matrix[0, 1] * b.Matrix[1, 1],
                               a.Matrix[1, 0] * b.Matrix[0, 0] + a.Matrix[1, 1] * b.Matrix[1, 0],
                               a.Matrix[1, 0] * b.Matrix[0, 1] + a.Matrix[1, 1] * b.Matrix[1, 1]);
        }

        public static Matrix2 operator /(Matrix2 a, int n)
        {
            double a11 = a.Matrix[0, 0] / n;
            double a12 = a.Matrix[0, 1] / n;
            double a21 = a.Matrix[1, 0] / n;
            double a22 = a.Matrix[1, 1] / n;
            return new Matrix2(a11, a12, a21, a11);
        }
        public override string ToString()
        {
            return $"Матрица: a11 = {Matrix[0,0]}; a12 = {Matrix[0, 1]}; a21 = {Matrix[2, 1]}; a22 = {Matrix[2, 2]}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix2 matr1 = new Matrix2(1, 2, 3, 4);
            Matrix2 matr2 = new Matrix2(-1, -2, -3, -8);

            Console.WriteLine(matr1.Det());
            Console.WriteLine(matr1.Inverse());
            Console.WriteLine(matr1.Transpose());

            Console.WriteLine(matr1 + matr2);
            Console.WriteLine(matr1 - matr2);
            Console.WriteLine(matr1/2);
        }
    }
}
