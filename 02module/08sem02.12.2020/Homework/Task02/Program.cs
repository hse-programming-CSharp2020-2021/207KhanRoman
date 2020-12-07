using System;
using MyLib;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<GeomProgr> geomProgrObj = new List<GeomProgr>(); ; // ссылка на объект типа GeomProgr
            bool flag;
            int b, q, n;
            do
            {
                flag = false;
                try
                {
                    do
                    {
                        Console.Write("Введите начальный член прогрессии: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("Введите знаменатель прогрессии: ");
                        q = int.Parse(Console.ReadLine());
                        geomProgrObj.Add(new GeomProgr(b, q));

                        do
                        {
                            Console.Write("Введите номер члена прогрессии: ");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine(geomProgrObj[geomProgrObj.Count - 1][n]);
                            Console.WriteLine(geomProgrObj[geomProgrObj.Count - 1].ProgrSum(n));
                            Console.WriteLine("Для ввода новых данных нажмите 'Enter'");
                        } while (Console.ReadKey().Key != ConsoleKey.Enter);
                        Console.WriteLine("Для завершения нажмите 'Esc'");
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    Console.WriteLine($"Всего прогрессий было создано - {geomProgrObj.Count}");
                }
                catch (ArgumentException ex)
                {
                    flag = true;
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    flag = true;
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    flag = true;
                    Console.WriteLine(ex.Message);
                }
            } while (flag);
        }
    }

}
