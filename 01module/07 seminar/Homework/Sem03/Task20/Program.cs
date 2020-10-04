using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDateN();
            int[] a = ArrayGen(n);
            int x = CorrecDateX();

            ArrayItemDouble(ref a, x);

            Output(a);
        }
        // Суть задание. Метод, удваивающий значение X/
        public static void ArrayItemDouble(ref int[] A, int X)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    count++;
                }
            }
            int[] b = new int[A.Length + count];
            int p = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    b[p] = X;
                    b[p+1] = X;
                    p += 2;
                }
                else
                {
                    b[p] = A[i];
                    p++;
                }
                    
            }
            Array.Resize(ref A, A.Length + count);
            A = b;

        }
        // Вывод массива.
        public static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        // Генерируем массив.
        public static int[] ArrayGen(int n)
        {
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(10, 111);
            }
            return a;
        }
        // Проверка корректности введенных данных.(Для разрядности массива)
        private static int CorrecDateN()
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                {
                    Console.WriteLine("Error");
                }
                Console.Write("Введите размерность массива: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 1);
            return x;
        }
        // Проверка корректности введенных данных.(Для X).
        private static int CorrecDateX()
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                {
                    Console.WriteLine("Error");
                }
                Console.Write("какое число вы хотите удвоить: ");
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        }
    }
}

