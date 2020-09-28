using System;
using System.Text;
using System.Globalization;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Page7_Task06
{
    class Program
    {
        // Метод n-факториала.
        public static ulong factorial(long x)
        {
            ulong factorial = 1;
            for (uint i = 1; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        // Сумма, которая идет первой в задаче. Метод полностью ее повтаряет.
        public static double Sum1(double x)
        {
            double s = 1;
            double sum = 0;
            for (int i = 0; ; i++)
            {
                s = Math.Pow(-1, i) * Math.Pow(2, 2 * i + 1) * Math.Pow(x, 2 * i + 2) / Program.factorial(2 * i + 2);
                // Если значение не меняется, то мы достигли машинной точности.
                if (sum + s == sum + s - 1) break;
                sum += s;
            }
            return sum;
        }
        // Сумма, которая идет 2-ой в задаче. Метод также ее повторяет.
        public static double Sum2(double x)
        {
            double sum = 0;
            double s = 0;
            int i = 0;
            while (sum + s != sum + s - 1)
            {
                s = Math.Pow(x, i) / Program.factorial(i);
                if (s != s + 1)
                    sum += s;
                i++;
            }
            return sum;
        }
        // Здесь просто проверяем корректность введенных данных.
        private static double CorrectCheck()
        {
            double x;
            do
            {
                Console.WriteLine($"Введите x");
            } while (!double.TryParse(Console.ReadLine(), out x));
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                double x = Program.CorrectCheck();
                Console.WriteLine("Первая сумма: " + Program.Sum1(x));
                Console.WriteLine("Вторая сумма: " + Program.Sum2(x));

                Console.WriteLine("Нажмите Enter, чтобы выйти\nЛюбую другую клавишу - начать заново.");
                Key = Console.ReadKey();
            } while (Key.Key!=ConsoleKey.Enter);
        }
    }
}
