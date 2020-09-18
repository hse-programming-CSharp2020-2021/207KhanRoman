using System;
using System.Security.Cryptography.X509Certificates;

namespace Сем3._2
{
    class Program
    {
        public static double F(double x) {
            return x*x;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            double a;
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите Дельту:");
            double Delta;
            double.TryParse(Console.ReadLine(), out Delta);

            int n = (int)(a / Delta);
            double result = 0;
            int i = 0;
            for (i = 0; i < n; i++) {
                result += (double)(Delta*(Program.F(i*Delta)+Program.F((i+1)*Delta))/2);
            }
            i--;
            result +=(a-i*Delta)*(Program.F(i*Delta)+Program.F(a))/ 2;
            Console.WriteLine(result);
        }
    }
}
