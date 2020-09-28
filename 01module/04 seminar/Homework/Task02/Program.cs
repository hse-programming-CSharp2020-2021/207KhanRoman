using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.Serialization;
/*
    Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 28.09.2020
*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                int i, sum = 0;
                string CheckCoice = "";

                Console.WriteLine("Введите последовательность из целых чисел.\nn, если хотите закончить.");
                i = Numbers(ref sum, ref CheckCoice);

                // Выводим.
                Console.WriteLine("сумма - " + sum/i);

                Console.WriteLine("нажимте Enter, если хотите завершить программу\nЛюбую другую клавишу-продолжить");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        // Метод, в котором мы реализуем выбор(продолжить вводить последовательность или закончить)
        // Если значение sum(суммы отричательных чисел)<-1000, метод закончиться и вернет i (кол-во всех отричательных членов послед.)
        private static int Numbers(ref int sum, ref string CheckCoice)
        {
            int x=0;
            int i = 0;
            while (CheckCoice != "n" && sum >= -1000)
            {
                CheckCoice = Console.ReadLine();
                if (int.TryParse(CheckCoice, out x))
                {
                    sum += x<0? x : 0;
                    i++;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            return i;
        }
    }
}
