using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Page33_Task01
{
    class Program
    {
        public const string pathIntput = "input.txt";
        public const string pathOutput = "output.txt";
        // Проверем на коррекнтость.
        private static int[] ArrayConvert(string[] text)
        {
            if (text.Length==0)
            {
                int[] ErrorArray = new int[1] {11};
                return ErrorArray;
            }
            int[] Numbers = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (!int.TryParse(text[i], out Numbers[i]) || Numbers[i] > 10 || Numbers[i]<-10)
                {
                    Numbers[i] = 11;
                    Console.WriteLine("неверные значения в исходном файле!");
                    break;
                }
            }
            return Numbers;
        }
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(pathIntput).Split('\n', ' ', '\t');
            int[] a = ArrayConvert(text);
            bool[] l = new bool[a.Length];

            // Записываем булевский массив в файл(если данные корректны).
            if (!Array.Exists(a, x => x==11))
            {
                File.WriteAllText(pathOutput, string.Empty);
                for (int i = 0; i<l.Length; i++)
                {
                    l[i] = a[i] > 0 ? true : false;
                    File.AppendAllText(pathOutput, l[i].ToString()+'\n');
                }
            }
            else
            {
                File.WriteAllText(pathOutput, "Ошибка");
            }
        }

        
    }
}
