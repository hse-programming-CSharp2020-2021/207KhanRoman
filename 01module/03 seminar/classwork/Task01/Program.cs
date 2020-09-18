using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void M1(int a)
        {
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Ваша оченка - неудовлетворительно");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Ваша оченка - удовлетворительно");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Ваша оченка - хорошо");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Ваша оченка - отлично");
                    break;

            }
        }
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Введите оценку :");
            } while (!int.TryParse(Console.ReadLine(), out a));
            Program.M1(a);
        }
    }
}
