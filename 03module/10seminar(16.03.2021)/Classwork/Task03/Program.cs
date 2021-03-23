using System;
using System.IO;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream st = new FileStream("text.txt", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(st);
                Random rand = new Random();
                for (int i = 0; i < 100; i++) sw.WriteLine(rand.Next(100, 1000) + rand.NextDouble());
                Console.SetIn(new StreamReader(st));

                double sum = 0;
                for (int i = 0; i < 100; i++)
                {
                    var n = Console.ReadLine();
                    sum += double.Parse(n);
                }
                Console.WriteLine(sum/100);
                Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            }
           
        }
    }
}
