using System;
using MyLabForTask03;

namespace Task03
{
    class Program
    {
        public static string RandString ()
        {
            string str = "";
            Random rnd = new Random();
            for (int i = 0; i<rnd.Next(0,30); i++)
            {
                str += rnd.Next('a', 'z');
            }
            return str;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Employee[] arr = new Employee[rnd.Next(1,101)];
            for (int i = 0; i<arr.Length; i++)
            {
                if (rnd.Next(0, 3) % 2 == 0) arr[i] = new SalesEmployee(RandString(), rnd.Next(0, 201), rnd.Next(0, 10));
                else arr[i] = new PartTimeEmployee(RandString(), rnd.Next(0, 201), rnd.Next(0, 26));
            }
            Array.Sort(arr, (x,y) => {
                if (x.CalculatePay() < y.CalculatePay()) return 1;
                else if (x.CalculatePay() > y.CalculatePay()) return -1;
                else return 0;
            });
            Console.WriteLine("С доп бонусом работник");
            Array.ForEach(Array.FindAll(arr, x => x is SalesEmployee), x => Console.WriteLine(x.CalculatePay()));
            Console.WriteLine("\nВнештатный  работник");
            Array.ForEach(Array.FindAll(arr, x => x is PartTimeEmployee), x => Console.WriteLine(x.CalculatePay()));
        }
    }
}
