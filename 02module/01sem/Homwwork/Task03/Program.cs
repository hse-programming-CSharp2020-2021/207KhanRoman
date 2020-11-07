using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Task03
{
    class RegularPolygon
    {
        int numberOfSides;
        double r;
        public int NumberOfSides
        {
            get
            {
                return numberOfSides;
            }
            set
            {
                if (value > 0)
                    numberOfSides = value;
                else throw new Exception(":(");
            }
        }
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0)
                    r = value;
                else throw new Exception(":(");
            }
        }
        public double Side
        {
            get
            {
                return 2 * r * Math.Sin(180 / numberOfSides);
            }
        }
        public double P
        {
            get
            {
                return Side * numberOfSides;
            }
        }
        public double S
        {
            get
            {
                return 1.0 / 2 * R * NumberOfSides;
            }
        }

        public RegularPolygon()
        {
            r = 2.5;
            numberOfSides = 10;
        }
        public string PolygonData()
        {
            return $"{NumberOfSides} {R} {Side} {P} {S}";
        }
    }
    class Program
    {
        public static int GetInt()
        {
            bool err = false;
            int x;
            do
            {
                if (err) Console.WriteLine("Error");
                Console.WriteLine("Введите размеронтсть массива");
            } while (!int.TryParse(Console.ReadLine(), out x) && x <= 0);
            return x;
        }
        static void Main(string[] args)
        {
            int n = GetInt();
            RegularPolygon[] shape = new RegularPolygon[n];
            for (int i = 0; i < shape.Length; i++)
            {
                shape[i] = new RegularPolygon();
                try
                {
                    Console.WriteLine($"Ведите данные об обьекте №{i + 1}");
                    Console.Write($"радиус: ");
                    shape[i].R = double.Parse(Console.ReadLine());
                    Console.Write($"колличество сторон: ");
                    shape[i].NumberOfSides = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("некрректный ввод");
                }
            }
            double max = double.MinValue;
            int maxId = -1;
            double min = double.MaxValue;
            int minId = -1;
            for (int i = 0; i < shape.Length; i++)
            {
                if (max < shape[i].S)
                {
                    max = shape[i].S;
                    maxId = i;
                }
                if (min > shape[i].S)
                {
                    min = shape[i].S;
                    minId = i;
                }
            }
            Console.Clear();
            for (int i = 0; i < shape.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i == maxId)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (i == minId)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"свойства {i+1}-ой фигуры : {shape[i].PolygonData()}");
            }
        }
    }
}
