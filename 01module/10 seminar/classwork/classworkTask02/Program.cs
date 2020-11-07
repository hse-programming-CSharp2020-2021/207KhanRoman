using System;
using System.Threading;

namespace classworkTask02
{
    class Program
    {
        public static double[] ArragyGen (int n)
        {
            Random rnd = new Random();
            double[] array = new double[n];
            for (int i = 0; i<array.Length; i++)
            {
                array[i] = rnd.Next(-4,5)+rnd.NextDouble();
            }
            return array;
        }
        public static (double[] inx, double[] outx, double[] iny, double[] outy) InMethod(double[] x, double[] y) {

            double[] xOut = new double[x.Length];
            double[] xIn = new double[x.Length];
            double[] yOut = new double[x.Length];
            double[] yIn = new double[x.Length];

            int countXInt = 0;
            int countYInt = 0;
            int countXOut = 0;
            int countYOut = 0;

            for (int i = 0; i<x.Length; i++)
            {
                if ((x[i]<=4 && x[i]>=2) || (x[i] >= -4 && x[i] <= -2))
                {
                    xIn[countXInt] = x[i];
                    countXInt++;
                }
                if ((x[i] <= 2 && x[i] >= -2) || (x[i] >= 4 || x[i] <= -4))
                {
                    xOut[countXOut] = x[i];
                    countXOut++;
                }
                if ((y[i] <= 4 && y[i] >= 2) || (y[i] >= -4 && y[i] <= -2))
                {
                    yIn[countYInt] = x[i];
                    countYInt++;
                }
                if ((y[i] <= 2 && y[i] >= -2) || (y[i] >= 4 || y[i] <= -4))
                {
                    yOut[countYOut] = x[i];
                    countYOut++;
                }
            }
            if (countXInt>0) Array.Resize(ref xIn, countXInt);
            if (countXOut > 0) Array.Resize(ref xOut, countXOut);
            if (countYInt > 0) Array.Resize(ref yIn, countYInt);
            if (countYOut > 0) Array.Resize(ref yOut, countYOut);
            return (xIn, xOut, yIn, yOut);
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Введите число элиментов массиве");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

            double[] x = ArragyGen(n);
            double[] y = ArragyGen(n);
            double[] xOut = InMethod(x, y).outx;
            double[] xIn = InMethod(x, y).inx;
            double[] yOut = InMethod(x, y).outy;
            double[] yIn = InMethod(x, y).iny;

            Array.ForEach(xIn, x => Console.Write($"{x:f2} "));
            Console.WriteLine();
            Array.ForEach(yIn, x => Console.Write($"{x:f2} "));
            Console.WriteLine();
            Array.ForEach(xOut, x => Console.Write($"{x:f2} "));
            Console.WriteLine();
            Array.ForEach(yOut, x => Console.Write($"{x:f2} "));
            Console.WriteLine();
        }
    }
}
