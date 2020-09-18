using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напряжение:");
            float U;
            float.TryParse(Console.ReadLine(), out U);
            Console.WriteLine("Сопротивление:");
            float R;
            float.TryParse(Console.ReadLine(), out R);
            if (U * R > 0)
            {
                float I = U / R;
                Console.WriteLine("Сила тока - " + I);
                float P = U * U / R;
                Console.WriteLine("Потребляемая мощность - " + P);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
