using System;
using System.Globalization;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача: Ввести бюджет, процент на игры и вывести сумму на игры в разных валютах(в зависимости от выбора пользователя)
*/
namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                double n;
                int r;
                do
                {
                    Console.Write("Введите бюджет: ");
                } while (!double.TryParse(Console.ReadLine(), out n));
                do
                {
                    Console.Write("Введите % на игры: ");
                } while (!int.TryParse(Console.ReadLine(), out r) || r>100 || r<0);

                Console.WriteLine("В какой валюте?");
                string a = Console.ReadLine();

                // Общая сумма на игры в рублях.
                n = n * r / 100;

                //2.3 Вывод. Случаи для разных валют.
                switch (a) {
                    case "доллар":
                        Console.WriteLine(string.Format(new CultureInfo("en-US"), "Сумма на игры = {0:c}", n/73));
                        break;
                    case "евро":
                        Console.WriteLine(string.Format(new CultureInfo("de-DE"), "Сумма на игры = {0:c}", n / 88));
                        break;
                    case "рубль":
                        Console.WriteLine("Сумма на игры = {0:c}", n);
                        break;
                    default:
                        Console.WriteLine("Неизвестная валюта");
                        break;
                }

                // 2.4 Эпилог.
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
