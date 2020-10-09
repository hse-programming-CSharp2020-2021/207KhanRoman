using System;
using System.IO;
// Я добавил генерацию массива в исходном файле, чтобы не вписывать его рукиами. Надеюсь, это не будет проблемой.
namespace Page33_Task02
{
    class Program
    {
        public const string pathIntput = "input.txt";
        public const string pathOutput = "output.txt";
        static void Main(string[] args)
        {
            int n = CorrectDataCheck();
            ArrayGen(n);
            string[] Elements = File.ReadAllText(pathIntput).Split('\n');
            int[] a = ArrayConvert(Elements);
            int[] b = new int[a.Length-1];
            ArrayBandOutput(a, ref b);
        }

        // Создаем массив B и сразу же записываем его значения в файл.
        private static void ArrayBandOutput(int[] a, ref int[] b)
        {
            File.WriteAllText(pathOutput, string.Empty);
            for (int i = 0; i < b.Length; i++)
            {
                int p = 1;
                while (p < a[i])
                {
                    p *= 2;
                }
                b[i] = p / 2;
                File.AppendAllText(pathOutput, b[i].ToString() + '\n');
            }
        }
        // Конвертитуем массив строк, полученный из файла в целочисленный массив.
        private static int[] ArrayConvert(string[] Elements)
        {
            int[] Digits = new int[Elements.Length];
            for (int i = 0; i < Elements.Length; i++)
            {
                int.TryParse(Elements[i], out Digits[i]);
            }
            return Digits;
        }

        // Генерируем массив и записываем его в файл.
        public static void ArrayGen(int n)
        {
            Random rnd = new Random();
            File.WriteAllText(pathIntput, string.Empty);
            for (int i = 0; i < n; i++)
            {
                File.AppendAllText(pathIntput, rnd.Next(0, 10001).ToString() + '\n');
            }
        }
        // Проверка коррекнтости введенных пользователем данных.
        private static int CorrectDataCheck()
        {
            int x;
            bool ErrorCheck = false;
            do
            {
                if (ErrorCheck)
                {
                    Console.WriteLine("Неверный ввод!");
                }
                ErrorCheck = true;
                Console.WriteLine("Введите колличество эллиментов в исходном массиве:");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 1);
            return x;
        }
    }
}
