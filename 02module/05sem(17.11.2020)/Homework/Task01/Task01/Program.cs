using System;
using MyLabForTask01;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            Random ran = new Random();
            for (int k = 0; k < arr.Length; k++)
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A(((char)ran.Next('a','z')).ToString());
                else arr[k] = new B(ran.Next(0,100));
            foreach (A d in arr) d.getA();
            Console.WriteLine("\nОбъекты класса B: ");
            foreach (A d in arr)
                if (d is B) d.getA();
            Console.WriteLine("\nОбъекты класса A: ");
            foreach (A d in arr)
                if (d is A && !(d is B)) d.getA();
            Console.WriteLine();

        }
    }
}
