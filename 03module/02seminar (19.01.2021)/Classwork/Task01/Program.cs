using System;

namespace Task01
{
    delegate string ConvertRule(string a);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate("Введите колво текстовых строк");
            string[] arr = new string[n];

            Console.WriteLine("Введите все строки:");
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            ConvertRule del1 = RemoveDigits;
            ConvertRule del2 = RemoveSpaces;

            Converter cv = new Converter();

            Console.WriteLine();
            Array.ForEach(arr, x => Console.WriteLine(cv.Convert(x, del1)));
            Array.ForEach(arr, x => Console.WriteLine(cv.Convert(x, del2)));

            ConvertRule del3 = del1 + del2;

            Console.WriteLine();
            for (int i = 0; i<arr.Length; i++)
            {
                string current = arr[i];
                current = cv.Convert(current, del3);
                Console.WriteLine(current);
            }
            
        }
        public static string RemoveDigits(string str)
        {
            char[] newStr = Array.FindAll(str.ToCharArray(), x => !int.TryParse(x.ToString(), out int c));
            return string.Join("", newStr);
        }
        public static string RemoveSpaces(string str)
        {
            return string.Join("", str.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }

        public static int Validate(string text)
        {
            bool error = false;
            int x;
            do
            {
                if (error) Console.WriteLine("Ошибка, попробуйте еще раз!");
                Console.Write(text);
                error = true;
            } while (!(int.TryParse(Console.ReadLine(), out x) && x > 0));
            return x;
        }
    }
}
