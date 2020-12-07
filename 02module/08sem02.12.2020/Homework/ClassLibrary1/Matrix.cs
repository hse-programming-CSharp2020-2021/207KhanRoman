using System;

namespace MyLib
{
    /// <summary>
    /// Класс для Task01.
    /// </summary>
    public class Matrix
    {
        int[,] matrix;
        public Matrix()
        {
            int n = TechnicalClass.GetIntValue("Введите порядок матрицы:");
            if (n <= 0) throw new ArgumentException("Порядок должен быть положительным!");
            matrix = new int[n, n];
        }
        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void EMatrix()
        {
            Array.Clear(matrix, 0, matrix.Length);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = 1;
            }
        }

    }
}
