using System;

namespace Task11
{
    class GeometricProgression
    {
        double _start;
        double _increment;
        public double _Start
        {
            get
            {
                return _start;
            }
            set
            {
                _start = value;
            }
        }
        public double _Increment
        {
            get
            {
                return _increment;
            }
            set
            {
                _increment = value;
            }
        }

        public GeometricProgression()
        {
            _Start = 0;
            _Increment = 1;
        }
        public GeometricProgression(double start, double increment)
        {
            _Start = start;
            _Increment = increment;
        }
        public double this[int index]
        {
            get
            {
                if (index > 0)
                    return _Start * Math.Pow(_Increment, index - 1);
                else throw new Exception("Неверный индекс");
            }
        }
        public override string ToString()
        {
            return $"Последовательность с знаменателем {_Increment:f2}, Первый элимент - {_Start:f2}";
        }

        public double GetSum(int n)
        {
            if (n > 0)
            {
                return (Math.Pow(_Increment, n) - 1) * _Start / (_Increment - 1);
            }
            else throw new Exception("Неверное колличество членов последовательности");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                GeometricProgression prog = new GeometricProgression();
                Random rnd = new Random();
                GeometricProgression[] progArray = new GeometricProgression[rnd.Next(5, 16)];
                for (int i = 0; i < progArray.Length; i++)
                {
                    progArray[i] = new GeometricProgression(rnd.Next(0, 10) + rnd.NextDouble(), rnd.Next(1, 5) + rnd.NextDouble());
                }
                int step = rnd.Next(3, 16);
                Console.WriteLine("\nИнформация о всех прогрессиях:");
                Array.ForEach(progArray, y => Console.WriteLine(y.ToString()));
                Console.WriteLine("Уникальная:" + prog.ToString());

                Console.WriteLine("\nВсе последовательности из массива, у которых элемент с номером step больше, чем у отдельной последовательности:");
                Array.ForEach(Array.FindAll(progArray, x => x[step] > prog[step]), y => Console.WriteLine(y.ToString()));

                Console.WriteLine("\nВыводим сумму первых step членов");
                Array.ForEach(progArray, x => Console.WriteLine(x.ToString() + $"\tСумма: {x.GetSum(step):f2}"));

                Console.WriteLine("\nНажмите Escape, если хоитте выйти\nИли любую другую клавишу, если хотите продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

