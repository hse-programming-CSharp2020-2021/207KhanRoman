using System;
using MyLib;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char start1, finish1, start2, finish2;
                do
                {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Введите русские символы(начало и конец)");
                        start1 = Console.ReadKey().KeyChar;
                        finish1 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.WriteLine("Введите латинские символы(начало и конец)");
                        start2 = Console.ReadKey().KeyChar;
                        finish2 = Console.ReadKey().KeyChar;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Введены неверные значения");
                    }
                } while (true);
                try
                {
                    MyStrings testString1 = new RusString(start1, finish1, 10);
                    MyStrings testString2 = new LatString(start2, finish2, 23);

                    Console.WriteLine("Для ру слов");

                    // тестируем неверные входные данные
                    try
                    {
                        Console.WriteLine(testString1);
                        Console.WriteLine(testString1.CountLetter('о'));
                        testString1 = new RusString(start1, start1, -11);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("За массив выходим :(");
                    }

                    Console.WriteLine("Для лат слов");
                    // тестируем неверные входные данные
                    try
                    {
                        Console.WriteLine(testString2);
                        Console.WriteLine(testString2.CountLetter('о'));
                        testString2 = new RusString(start2, start2, -11);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("За массив выходим :(");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Введеные неверные значения");
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
