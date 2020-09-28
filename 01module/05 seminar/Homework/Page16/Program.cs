using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Homework
{
    class Program
    {
        // 8.1
        public static double[] ArrayGen(int n)
        {
            double[] NewArray = new double[n];
            for (int i = 0; i < n; i++)
            {
                NewArray[i] = (i * (i + 1) / 2)%n;
            }
            return NewArray;
        }
        // 8.2
        // Если я правильно понлял, нормирование - приведение всех значений массива к интервалу [-1;1].
        public static double[] ArrayNorm(double[] Array)
        {
            double Max = 0;
            for (int i = 0; i<Array.Length; i++)
            {
                if (Math.Abs(Array[i]) > Max)
                {
                    Max = Array[i];
                }
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] /= Max;
            }
            return Array;
        }
        // 8.3
        public static void PrintArray (double[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"{i+1}-ый эллемент массива = {Array[i]:F3}");
            }
        }
        // Метод просто проверяет введенное число.
        public static int DigitCheck()
        {
            int n;
            do
            {
                Console.Write("Введите размерность массива(n)\nПомните, что n долно быть натуральным числом!\nn = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n<1);
            return n;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                // 8.4
                int n = Program.DigitCheck();
                double[] Array = Program.ArrayGen(n);
                Program.PrintArray(Array);
                Array = Program.ArrayNorm(Array);
                Program.PrintArray(Array);

                Console.WriteLine("Введие Enter, чтобы продожить\nЛюбую другую клавишу - начать заново");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
