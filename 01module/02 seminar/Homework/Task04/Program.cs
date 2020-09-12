using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_2
{
    class Program
    {
        public static void Metod1(int x)
        {
            while (x > 0)
            {
                Console.WriteLine(x % 10);
                x /= 10;
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key;
            do
            {
                int x;
                do
                {
                    Console.Write("Введие натуральное четырехзначное число: ");
                } while (!int.TryParse(Console.ReadLine(), out x) && x < 10000 && x > 999);
                Program.Metod1(x);

                Console.WriteLine("Для выхода из программы нажмите Enter");
                Key = Console.ReadKey();
                Console.WriteLine("");
            } while (Key.Key != ConsoleKey.Enter);
        }
    }
}
