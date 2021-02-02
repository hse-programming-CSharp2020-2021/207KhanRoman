using System;

namespace Task05
{
    delegate void ToDo();
    static class ArrayWork
    {
        public static event ToDo newLine;
        public static void ArrayWrite(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                newLine?.Invoke();
            }
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = Validate("Введите размерность");
            int[,] arr = new int[n,n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            ArrayWork.newLine += () => Console.WriteLine();

            ArrayWork.ArrayWrite(arr);

            ArrayWork.newLine += () => Console.WriteLine("****");

            ArrayWork.ArrayWrite(arr);

        }
        public static int Validate(string a)
        {
            bool error = false;
            int x;
            do
            {
                if (error) Console.WriteLine("Неверно");
                Console.WriteLine(a);
                error = true;
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        }
    }
}
