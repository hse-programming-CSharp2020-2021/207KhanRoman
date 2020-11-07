using System;
using System.Runtime.CompilerServices;

namespace Task07
{
    class Sin
    {
        double xmin;
        double xmax;
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public Sin (double min, double max)
        {
            Xmin = min;
            Xmax = max;
        }
        public double this[double index]
        {
            get
            {
                return (index >= Xmin && index <= Xmax ? Math.Sin(index) : 0);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sin sin = new Sin(0, Math.PI);
            for (double i = 0; i<Math.PI; i+=Math.PI/6)
            {
                Console.WriteLine(sin[i]);
            }
        }
    }
}
