using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace classwork
{
    class Program
    {
        public static int[] ValueCorrect(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    Console.Write("Введите элимент посследовательности: ");
                } while (!int.TryParse(Console.ReadLine(), out x));
                array[i] = x;
            }
            return array;
        }
        public static int[] Primes(int[] sequence)
        {
            int pcount = 0;
            int[] parray = new int[sequence.Length];
            for (int i = 0; i < sequence.Length; i++)
            {
                
                parray[pcount] = sequence[i];
                pcount++;
                
                    for (int j = 2; j < sequence[i]; j++)
                    {
                        if (sequence[i] % j == 0)
                        {
                            pcount--;
                            parray[pcount] = 0;
                            break;
                        }
                    }
                
            }
            Array.Resize(ref parray, pcount);
            return parray;
        }
        public static bool IsNonDecreasing(int[] sequence, out int min) {
            bool check = true;
            min = int.MaxValue;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            for (int i = 0; i < sequence.Length-1; i++)
            {
                if (sequence[i + 1] < sequence[i])
                {
                    check = false;
                }
            }
            return check;
        }

        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.WriteLine("Введите число элиментов массиве");
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);
                int[] array = ValueCorrect(n);
                int[] primes = Primes(array);
                Console.WriteLine($"{primes.Length}\t");
                Array.ForEach(primes, x => Console.WriteLine(x));

                int min = int.MaxValue;
                Console.WriteLine($"Последовательность неубывающая:{IsNonDecreasing(array, out min)}");
                Console.WriteLine(min);
                Console.WriteLine("Нажмите Enter, чтобы выйти");
            } while (Console.ReadKey().Key!=ConsoleKey.Enter);
        }
    }
}

