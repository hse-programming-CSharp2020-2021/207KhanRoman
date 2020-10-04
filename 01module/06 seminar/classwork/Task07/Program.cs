using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =0;
            string x = Console.ReadLine();
            char[] a = new char[x.Length];
            while (x.Length>0)
            {
                int p = x.Length -1;
                a[p] = (char)(((int)x[p]) % 10);
                i++;
                x = x.Substring(0, x.Length - 1);
            }
            Array.ForEach(a, x => Console.WriteLine(x));

        }
    }
}
