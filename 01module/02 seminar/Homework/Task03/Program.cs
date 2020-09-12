using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача:
*/
namespace Homework_2
{
    class Program
    {
        public static void Metod()
        {

        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}