using System;
using MyLib;

namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Matrix matrix = new Matrix();
                    matrix.EMatrix();
                    matrix.Print();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Для завершения нажмите 'Enter'");
            } while (Console.ReadKey().Key!=ConsoleKey.Enter);
        }
    }
}
