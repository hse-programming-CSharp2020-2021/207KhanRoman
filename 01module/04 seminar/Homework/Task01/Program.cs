using System;
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
        // Находим все тройки, для которых выполняется теорема пифагора (отрезок [1,20])
        public static void Metod1(int a, int b, int c)
        {
            // Описываю, как работает алгоритм:
            // Мы пробегаем все возможные значения a и проверяем для таких пар (a,b) будет ли с тоже целым.
            // Если с целое, то 2-ой if будет выполнятся.
            // Мы сразу выводим все возможные растоновки знаков перед a,b,c.
            // После того, как а=21, мы b+1 и а=1.
            // Продолжаем до тех пор, пока b<21;
            while (b < 21)
            {
                a++;
                if (a == 21) {
                    b++;
                    a = 1;
                }
                c = (int)Math.Sqrt(a * a + b * b);
                if (a*a+b*b==c*c && c<20)
                {
                    Console.WriteLine($"тройка - {a},{b},{c}");
                    Console.WriteLine($"тройка - {-a},{b},{c}");
                    Console.WriteLine($"тройка - {a},{-b},{c}");
                    Console.WriteLine($"тройка - {a},{b},{-c}");
                    Console.WriteLine($"тройка - {-a},{-b},{c}");
                    Console.WriteLine($"тройка - {a},{-b},{-c}");
                    Console.WriteLine($"тройка - {-a},{b},{-c}");
                    Console.WriteLine($"тройка - {-a},{-b},{-c}");
                }
            }

        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                int a = 1, b = 1, c = 1;
                Program.Metod1(a, b, c);

                Console.WriteLine("Нажмите Enter, чтобы выйти\nЛюбую другую клавишу - начать заново.");
                Key = Console.ReadKey();
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
