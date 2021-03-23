using System;

namespace classwork
{
    interface ICalculete
    {
        double Perform(double x);
    }
    class Add : ICalculete
    {
        public double Number { get; }
        public Add (double x)
        {
            Number = x;
        }
        public double Perform(double x)
        {
            return x + Number;
        }
    }
    class Multiply : ICalculete
    {
        public double Number { get; }
        public Multiply(double x)
        {
            Number = x;
        }
        public double Perform(double x)
        {
            return x * Number;
        }
    }
    class Program
    {
        public static double Calculete(int n, Add func1, Multiply func2)
        {
            return func2.Perform(func1.Perform(n));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            var newX = Calculete(1, new Add(2), new Multiply(3));
            Console.WriteLine(newX);
        }
    }
}
