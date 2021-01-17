using System;
using TechnicalLub;

namespace Task03
{
    delegate double delegateConvertTemperature(double n);
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                delegateConvertTemperature[] delArray = {
                                new TemperatureConverterImp().CtoF,
                                new TemperatureConverterImp().FtoC,
                                StaticTempConverters.CtoK,
                                StaticTempConverters.CtoRa,
                                StaticTempConverters.CtoRe,
                                StaticTempConverters.KtoC,
                                StaticTempConverters.RatoC,
                                StaticTempConverters.RetoC,
                            };

                double f = TechnicalClass.Validate("Введите температуру в Фаренгейтах: ", x => x >= -459.67);
                Console.WriteLine($"Переводим в Цельсия: {delArray[1](f):f3}");

                double c = TechnicalClass.Validate("\nВведите температуру в Цельсия: ", x => x >= -273.15);
                Console.WriteLine($"Переводим в Фаренгейты:\t{delArray[0](c):f3}");
                Console.WriteLine($"Переводим в Кельвины:\t{delArray[2](c):f3}");
                Console.WriteLine($"Переводим в Ранкины:\t{delArray[3](c):f3}");
                Console.WriteLine($"Переводим в Реомюры:\t{delArray[4](c):f3}");

                Console.WriteLine("\nНажмите Escape, чтобы выйти, или любую другую клавишу, чтобы продолжыть");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
