using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace classwork
{
    class TriangleNums
    {
        public double current;
        public IEnumerable<double> MyIterator(int n)
        {
            for (int i = 0; i < n; i++)
            {
                current = 1.0 / 2 * i * (i + 1);
                yield return current;
                if (i == n - 1)
                    yield break;
            }
        }
    }
    class Fibbonacci
    {
        int penultimate = 0;
        int last = 1;

        public IEnumerable<int> MyIterator(int n)
        {
            penultimate = 0;
            last = 1;
            for (int i = 0; i < n; i++)
            {
                (penultimate, last) = (last, penultimate + last);
                yield return last;
                if (i == n - 1)
                    yield break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fi = new Fibbonacci();
            TriangleNums tr = new TriangleNums();

            foreach (int numb in fi.MyIterator(7))
                Console.Write(numb + "  ");
            Console.WriteLine();


            foreach (double numb in tr.MyIterator(7))
                Console.Write(numb + "  ");
            Console.WriteLine();

            var fib = fi.MyIterator(7).ToArray();
            int index = 0;
            foreach (double numb in tr.MyIterator(7))
            {
                Console.Write(numb + fib[index] + "  ");
                index++;
            }
            Console.WriteLine();
        }
    }
}
