using System;
using MyLib;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticTrinomial polinom1 = new QuadraticTrinomial(2, -21, 5);
            QuadraticTrinomial polinom2 = new QuadraticTrinomial(4, -2, 23);

            int[] array = { 1, -3, 3, 2, 7, 100, 0 };

            foreach (int i in array)
            {
                try
                {
                    Console.WriteLine($"{polinom1.Division(polinom2, i):f2}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Деление на 0");
                }
            }
        }
    }
}
