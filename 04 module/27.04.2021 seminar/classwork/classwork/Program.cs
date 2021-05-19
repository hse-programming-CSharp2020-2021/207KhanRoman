using System;
using System.Collections;

namespace classwork
{
    class Fibbonacci
    {
        int penultimate = 0;
        int last = 1;

        public IEnumerable MyIterator(int n)
        {
            for (int i = 0; i<n; i++)
            {
                (penultimate, last) = (last, penultimate + last);
                yield return last;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fi = new Fibbonacci();

            foreach (int numb in fi.MyIterator(7))
                Console.Write(numb + "  ");
            Console.WriteLine();


            foreach (int numb in fi.MyIterator(7))
                Console.Write(numb + "  ");
            Console.WriteLine();
        }
    }
}
