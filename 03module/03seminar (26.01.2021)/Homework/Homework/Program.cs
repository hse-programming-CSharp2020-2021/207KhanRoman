using System;
using System.Linq;

namespace Task05
{
    delegate void ToDo();
    delegate void FillReact(int[,] a);
    static class ArrayWork
    {
        public static event ToDo newLineWrite;
        public static event FillReact NewItemFilled;
        static Random rnd = new Random();
        public static void ArrayWrite(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                newLineWrite?.Invoke();
            }
        }
        public static void ArrayFill(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10);
                    NewItemFilled?.Invoke(arr);
                }
            }
        }
        public static void ArrSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
        }
        // Я так и не понял, что подразумевается под "заполненый" элемент, поэтому написал так.
        public static void ArrayAvarege(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum); 
        }
        public static void ArrayMaxInsert(int[,] arr)
        {
            int max = -100;
            foreach(int n in arr)
            {
                if (max < n) max = n;
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max == arr[i,j])
                    {
                        arr[i, j] = rnd.Next(10);
                    }
                }
            }
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = Validate("Введите размерность");
            int[,] arr = new int[n, n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }

            ArrayWork.newLineWrite += () => Console.WriteLine();

            ArrayWork.ArrayWrite(arr);

            ArrayWork.newLineWrite += () => Console.WriteLine("****");

            ArrayWork.ArrayWrite(arr);

            ArrayWork.NewItemFilled += ArrayWork.ArrSum;

            ArrayWork.NewItemFilled += ArrayWork.ArrayAvarege;

            ArrayWork.NewItemFilled += ArrayWork.ArrayMaxInsert;

            ArrayWork.ArrSum(arr);

            ArrayWork.ArrSum(arr);
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
