using System;
/*
    1.1 Шапка

    Дисциплина: "Программирование"
    Группа: 207ПИ/2
    Студент: Хан Роман
    Дата: 12.09.2020
    Задача:
*/
namespace Homework_3
{
    class Program
    {
        public static void Metod1(ref int s, ref int n)
        {
            while (s%10 != s/100 || s/100 !=(s/10)%10) {
                s += n;
                n++;
            }
            n--;
        }
        static void Main(string[] args)
        {
            // 1.2
            ConsoleKeyInfo Key;
            // 2.1 Ввод
            do
            {
                int s=1, n=2;
                Program.Metod1(ref s, ref n);
                Console.WriteLine("Число s: {0}\nКолличество членов ряда: {1}", s, n);
                Console.WriteLine($"Условное изображение суммы: 1+2+3...+{n-2}+{n-1}+{n}");
                // 2.4 Эпилог
                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
