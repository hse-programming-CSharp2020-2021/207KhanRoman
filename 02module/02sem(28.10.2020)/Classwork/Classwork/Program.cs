using System;
using System.Linq;

namespace DoubleArr
{
    class Circle
    {
        double _r;
        public double Radius
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius should be non-negative");
                _r = value;
            }
        }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }
        public double L
        {
            get
            {
                return Math.PI * _r * 2;
            }
        }

        public Circle()
        {
            Radius = 1;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle: radius = {L:f3}, Square = {S:f3}";
        }
    }

    /*
     * этап 2
     * Свойство подсчета длины окружности. 
     * Ввести значение n.
     * Генерируем массив из кругов со случайным значением радиуса (Rmin, Rmax)
     * Для всех кругов считаем площадь и длину окружности и вывести на экран.
     * Найти круг с наибольшей площадью и вывести его на экран.
*/

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Circle[] circleArray = new Circle[n];
            Random rnd = new Random();
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            // double delta = double.Parse(Console.ReadLine());

            //Circle circle;
            double s = int.MinValue;
            for (int i = 0; i < circleArray.Length; i++)
            {
                circleArray[i] = new Circle(rnd.Next((int)rmin+1,(int)rmax+1)-rnd.NextDouble());
                Console.WriteLine(circleArray[i].ToString());
                if (circleArray[i].S>s)
                {
                    s = circleArray[i].S;
                }
            }
            Console.WriteLine(s);
        }
    }
}
