using System;

namespace classwork
{
    delegate void SquareSizeChanged(double a);
    class Square
    {
        public event SquareSizeChanged OnSizeChanged;

        (int x, int y) firstPoint;
        (int x, int y) secondPoint;
        public (int x, int y) FirstPoint
        {
            get
            {
                return firstPoint;
            }
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(firstPoint.x - secondPoint.x));
                firstPoint = value;
            }

        }
        public (int x, int y) SecondPoint
        {
            get
            {
                return firstPoint;
            }
            set
            {
                OnSizeChanged?.Invoke(Math.Abs(firstPoint.x - secondPoint.x));
                secondPoint = value;
            }

        }
        public Square(int xFirst, int yFirst, int xSecond, int ySecond)
        {
            FirstPoint = (xFirst, yFirst);
            SecondPoint = (xSecond, ySecond);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int xFirst = Validate("Введите координаты первой точки(x)");
            int yFirts = Validate("Введите координаты первой точки(y)");
            int xSecond = Validate("Введите координаты второй точки(x)");
            int ySecond = Validate("Введите координаты второй точки(y)");

            Square newSquare = new Square(xFirst, yFirts, xSecond, ySecond);

            newSquare.OnSizeChanged += SquareConsoleInfor;

            do
            {
                int x = Validate("Введите координаты новой точки(x)");
                int y = Validate("Введите координаты новой точки(y)");

                newSquare.SecondPoint = (x, y);
                Console.WriteLine("Нажмите Eascape, чтобы выйти");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static void SquareConsoleInfor(double a)
        {
            Console.WriteLine($"{a:f2}");

        }
        public static int Validate(string a)
        {
            bool error = false;
            int x;
            do
            {
                if (error) Console.WriteLine("Неверно");
                Console.WriteLine(a);
                error = true;
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;
        }
    }
}
