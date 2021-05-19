using System;
using System.Linq;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            for(int i = 0; i<n; i++)
            {
                arr[i] = rnd.Next(-10000, 100001);
            }
            Console.WriteLine();

            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine();

            foreach (var x in arr.Select(x => x % 10).GroupBy(x => x))
            {
                Console.WriteLine(x.Key);
            }
            Console.WriteLine();

            Console.WriteLine(arr.Where(x => x > 0 && x % 2 == 0).Count());
            Console.WriteLine();

            Console.WriteLine(arr.Aggregate((i,j) => i%2==0 && j%2==0? i+j : i%2==0 ? i : j));
            Console.WriteLine();

            foreach (var x in arr.OrderBy(x => Math.Sign(x) * int.Parse((Math.Abs(x).ToString()[0].ToString()))).ThenBy(x => x % 10))
                Console.WriteLine(x);
            Console.WriteLine();

            Console.WriteLine();

        }
    }
}
