using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну катета №1 - ");
            float a;
            float.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите длинну катета №2 - ");
            float b;
            float.TryParse(Console.ReadLine(), out b);
            if (a * b > 0)
            {
                Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
