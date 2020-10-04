using System;
// Если я правильно понял, то нужно вывести элементы массива с номерами кратными k.
// Я предпологаяю, что номер элиментов массива не может начиться с 0 => a[0] - элимент №1, a[1] - элимент №2, и т.д.
namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = CorrecDateN();
            int k = CorrecDateK(n);

            int[] a = ArrayGen(n);
            Output(a, k);
        }
        // Вывод массива. (суть задания).
        public static void Output(int[] a, int k)
        {
            for (int i = k-1; i < a.Length; i+=k)
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
                a[i] = rnd.Next(-10, 11);
            }
            return a;
        }
        // Проверка корректности введенных данных для N.
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
        // Проверка корректности введенных данных для K.
        private static int CorrecDateK(int n)
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                {
                    Console.WriteLine("Error");
                }
                Console.Write("Введите K: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || x>n);
            return x;
        }
    }
}
