using System;
using System.Linq;

namespace Page31_Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу строку со значениями, разделенными точкой с запятой:");
            string str = Console.ReadLine();
            int[] Digits = ArrayGen(str);
            // Выводим сам массив.
            Array.ForEach(Digits, x => Console.Write(x+ " "));
            Console.WriteLine();
            // Выводим среднее арифметическое.
            Console.WriteLine(Digits.Average());
        }
        // Генерируем массив текущей строки.
        private static int[] ArrayGen(string str)
        {
            string[] Elements = str.Split(';');
            int[] Digits = new int[Elements.Length];
            int CountOfDigits = 0;
            for (int i = 0; i < Elements.Length; i++)
            {
                if (int.TryParse(Elements[i], out Digits[CountOfDigits]))
                {
                    CountOfDigits++;
                }
            }
            Array.Resize(ref Digits, CountOfDigits);
            return Digits;
        }
    }
}
