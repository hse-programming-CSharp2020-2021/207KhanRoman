using System;

namespace classwork
{
    class Program
    {
        delegate double Calcul(double x);
        static void Main(string[] args)
        {
            Calcul cl = x => {
                double sum = 0;
                for (int i = 0; i<5; i++)
                {
                    double p = 1;
                    for (int j = 0; j < 5; j++)
                    {
                        p *= i * x / j;
                    }
                    sum += p;
                }
                return sum;
            };
            Console.WriteLine(cl(5));
        }
    }
}
