using System;
using System.Collections.Generic;

namespace Task02
{
    interface ISequence
    {
        double GetElement(int n);
    }
    class ArithmeticProgression : ISequence
    {
        double FirstElement { get; }
        double Step { get; }
        public ArithmeticProgression(double firstElement, double step)
        {
            FirstElement = firstElement;
            Step = step;
        }
        public double GetElement(int n)
        {
            return FirstElement + (n - 1) * Step;
        }
    }
    class GeometricProgression : ISequence
    {
        double FirstElement { get; }
        double Step { get; }

        public GeometricProgression(double firstElement, double step)
        {
            FirstElement = firstElement;
            Step = step;
        }

        public double GetElement(int n)
        {
            return FirstElement * Math.Pow(Step, n-1);
        }
    }
    class Program
    {
        public static double Sum(ISequence progression, int n)
        {
            double Sum = 0;
            for (int i = 0; i<n; i++)
            {
                Sum += progression.GetElement(i+1);
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            var s = Sum(new ArithmeticProgression(3, 5), 10);
            Console.WriteLine(s);
        }
    }
}
