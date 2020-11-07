using System;
using System.Linq;

namespace Task07
{
    class Program
    {
        const int cvartals = 4;
        const int countOfPlants = 3;
        static void Main(string[] args)
        {
            int[,] arr = new int[cvartals, countOfPlants] { { 20, 24, 25 }, { 21, 20, 18 }, { 23, 27, 24 },{ 22, 19, 20 } };
            string[] namesOfF = new string[3] {"Западный", "Центральный", "Восточный"};
            // Пунк 1.
            int sum = 0;
            for (int i = 0; i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine($"Количество всех проданных машин = {sum}");
            // Пункт 2.
            int max = int.MinValue;
            int name = 0;
            int cvartal = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        name = j;
                        cvartal = i;
                    }
                }
            }
            Console.WriteLine($"Больше всего произвел {namesOfF[name]} филиал в {cvartal+1}-ом квартале - {max} машин");
            // Пункт 3.
            int max3 = int.MinValue;
            int name2 = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int yearSum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    yearSum += arr[j, i];
                }
                if (max3 < yearSum)
                {
                    max3 = yearSum;
                    name2 = i;
                }
            }
            Console.WriteLine($"Больше всего за год произвел {namesOfF[name2]} филиал - {max3} машин");
            // Пукнт 4.
            int max2 = int.MinValue;
            int cvart = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int yearSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    yearSum += arr[i, j];
                }
                if (max2 < yearSum)
                {
                    max2 = yearSum;
                    cvart = i;
                }
            }
            Console.WriteLine($"Самым удачным кварталом был {cvart+1}, продано {max2} машин");
        }
    }
}
