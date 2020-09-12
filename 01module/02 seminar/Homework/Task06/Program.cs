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
                double n;
                int r;
                do
                {
                    Console.Write("Введите бюджет: ");
                } while (!double.TryParse(Console.ReadLine(), out n));
                do
                {
                    Console.Write("Введите % на игры: ");
                } while (!int.TryParse(Console.ReadLine(), out r));

                Console.WriteLine("В какой валюте?");
                string a = Console.ReadLine();

                n = n * r / 100;
                switch (a) {
                    case "доллар":
                        Console.WriteLine("На игры выделенно {0:C2}", n/73);
                        break;
                    case "евро":
                        Console.WriteLine("На игры выделенно {0:C2}", n/80);
                        break;
                }

                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
