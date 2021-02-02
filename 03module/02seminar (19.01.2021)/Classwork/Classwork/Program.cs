using System;

namespace Classwork
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            do
            {
                int n = Validate("Введите колличество растений: ");
                int[] arr = new int[n];

                arr = Array.ConvertAll(arr, x => x=rnd.Next(-15,16));

                Array.ForEach(arr, Console.WriteLine);

                Array.Sort(arr, (x,y) => {
                    if (x>y) return 1;
                    else if (x<y) return 1;
                    else return 0;
                });
                Array.ForEach(arr, Console.WriteLine);

                Console.WriteLine("\nЕсли хотите выйти - нажмите Escape\nЛюбую другую клавишу - продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static int Validate(string text)
        {
            bool error = false;
            int x;
            do
            {
                if (error) Console.WriteLine("Ошибка, попробуйте еще раз!");
                Console.Write(text);
                error = true;
            } while (!(int.TryParse(Console.ReadLine(), out x) && x > 0));
            return x;
        }
    }
}
