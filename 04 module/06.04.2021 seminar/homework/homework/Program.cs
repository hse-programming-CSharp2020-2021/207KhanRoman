using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// Здесь представлен код с бинарной сериализацией.

namespace Task03
{
    delegate void Qdelegate(QuadraticEquation x);
    static class StaticMethods
    {
        static Random rnd = new Random();
        public static void WriteInFile(string filename, int n)
        {
            QuadraticEquation[] arr = new QuadraticEquation[n];
            for (int i = 0; i < n; i++)
            {
                try
                {
                    arr[i] = new QuadraticEquation(rnd.Next(0, 100) + rnd.NextDouble(),
                                                   rnd.Next(0, 100) + rnd.NextDouble(),
                                                   rnd.Next(0, 100) + rnd.NextDouble());
                }
                catch
                {
                    i--;
                }
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, arr);
            }
        }
        public static void ReadFromFile(string filename, Qdelegate del)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                QuadraticEquation[] arr = (QuadraticEquation[])bf.Deserialize(fs);
                for (int i = 0; i < arr.Length; i++)
                    try
                    {
                        del(arr[i]);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
            }
        }
        public static void PrintInfo(QuadraticEquation x)
        {
            Console.WriteLine(x);
        }
        public static void Solution(QuadraticEquation x)
        {
            if (x.Discr < 0) throw new ArgumentException($"{x} - не имеет решений");

            double x1 = -x.B + Math.Sqrt(x.Discr) / (2 * x.A);
            double x2 = -x.B - Math.Sqrt(x.Discr) / (2 * x.A);

            Console.WriteLine($"{x} - имеет корни x1={x1:f3} и x2={x2:f3}");
        }
    }
    [Serializable]
    class QuadraticEquation
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double Discr => B * B - 4 * A * C;
        public QuadraticEquation(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException("Линейные уравнения не рассматриваем");
            A = a;
            B = b;
            C = c;
        }
        public override string ToString()
        {
            return $"К.у.:  A = {A:f3}; B ={B:f3}; С = {C:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество кв уравнений:");
            int n = int.Parse(Console.ReadLine());
            StaticMethods.WriteInFile("equation.ser", n);
            Console.WriteLine("Выполнена запись в режиме сериализации.");

            Console.WriteLine("Для вывода на экран нажмите любую клавишу.");
            Console.ReadKey(true);

            // Обращение с использованием делегата:
            Console.WriteLine("В файле сведения о следующих уравнениях: ");
            StaticMethods.ReadFromFile("equation.ser", new Qdelegate(StaticMethods.PrintInfo));
            Console.WriteLine("Для решения уравнений нажмите любую клавишу.");
            Console.ReadKey(true);
            Console.WriteLine("\r\nРешения уравнений с вещественными корнями: ");
            StaticMethods.ReadFromFile("equation.ser", new Qdelegate(StaticMethods.Solution));
            Console.WriteLine("Для завершения работы нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
