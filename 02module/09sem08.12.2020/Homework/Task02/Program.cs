using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введие исхудную строку: ");
                string[] array = ClassForTask.ValidatedSplit(Console.ReadLine(), ';');
                
                if (array==null)
                {
                    Console.WriteLine("Беды с форматом");
                    Console.ReadKey();
                    continue;
                }
                Array.ForEach(array, x => Console.WriteLine(ClassForTask.Abbrevation(x.Trim())));


                Console.WriteLine("Если хотите выйти, но нажмите esc, любую другую клавишу - продолжить");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
