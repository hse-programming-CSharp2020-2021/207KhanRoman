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
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-1001,1001);

            var arr2 = arr.Select(x => x * x);
            var arr3 = arr.Where(x => x>0 && Math.Abs(x) > 9 && Math.Abs(x) < 100);
            var arr4 = arr.Where(x => x % 2 == 0).OrderBy(x => x);
            var arr5 = arr.GroupBy(x => Math.Log10(Math.Abs(x)) + 1);

            foreach (var a in arr)
                Console.WriteLine(a);
            Console.WriteLine();
            foreach (var a in arr2)
                Console.WriteLine(a);
            foreach (var a in arr3)
                Console.WriteLine(a);
            Console.WriteLine();
            foreach (var a in arr4)
                Console.WriteLine(a);
            Console.WriteLine();
            foreach (var a in arr5)
                Console.WriteLine(a);
            Console.WriteLine();
        }
    }
}
