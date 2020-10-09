using System;
using System.IO;
using System.Globalization;
using System.Text;

namespace Homework
{
    class Program
    {
        public const string path = "dialog.txt";
        // Генерируем строку.
        public static string LineGen()
        {
            Random rnd = new Random();
            
            string Line = "";
            int LineLength = rnd.Next(20, 51);
            for (int i = 0; i < LineLength; i++)
            {
                Line += ((char)rnd.Next('А', 'я')).ToString();
            }
            return Line + ".\n";
        }
        static void Main(string[] args)
        {
            FileGen(path);
            // Выводим иходный файл.
            Console.WriteLine("Original file is:\n" + File.ReadAllText(path));
            // Выводим файлы без точек.
            Console.WriteLine("File without dots:\n" + File.ReadAllText(path).Replace(".", ""));

        }

        // Генерируем файл.
        private static void FileGen(string path)
        {
            File.WriteAllText(path, string.Empty, Encoding.UTF8);
            for (int i = 0; i < 6; i++)
            {
                string line = LineGen();
                File.AppendAllText(path, line, System.Text.Encoding.UTF8);
            }
        }
    }
}