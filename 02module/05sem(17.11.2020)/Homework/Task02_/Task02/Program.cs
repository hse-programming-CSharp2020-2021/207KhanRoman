using System;
using MyLibForTask02;
using System.Linq;
// Если честно, я не понял совсем понял, что от меня просят в красной рамке в задании.
// Я использовал класс Point в качестве формы для других классов и не вкладывал како-либо смысл в Display() и Area(в задании это не просят, если я правильно понял),
// Поэтому от того, что уберу override ничего не изменится. 
namespace Task02
{
    class Program {
        public static Point[] FigArray ()
        {
            Random rnd = new Random();
            int rndCircleCount = rnd.Next(0, 11);
            int rndSquareCount = rnd.Next(0, 11 - rndCircleCount);
            Point[] arr = new Point[rndCircleCount+rndSquareCount];
            for (int i = 0; i<arr.Length; i++)
            {
                if (rnd.Next(0, 3) % 2 == 0) arr[i] = new Circle(rnd.Next(10, 101), rnd.Next(10, 101), rnd.Next(10, 101));
                else arr[i] = new Square(rnd.Next(10, 101), rnd.Next(10, 101), rnd.Next(10, 101));
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Point[] arr = FigArray();
            int countOfCircles = 0;
            int countOFSquare = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] is Circle)
                {
                    countOfCircles++;
                }
                else
                {
                    countOFSquare++;
                }
            }
            Console.WriteLine($"Колличество кругов - {countOfCircles}");
            Console.WriteLine($"Колличество квадратов - {countOFSquare}");
            Console.WriteLine("Среднаяя площадь" + arr.Average(x => x.Area));
            Console.WriteLine("Средний периметр" + arr.Average(x => x.Len));
            Array.Sort(arr, (x,y) => {
                if (x.Area > y.Area) return 1;
                else if (x.Area<y.Area) return -1;
                else return 0;
            });
            Console.WriteLine("\nВсе элементы отсортированного массива:");
            Array.ForEach(arr, x => Console.WriteLine(x.Area));
        }
    }
}
