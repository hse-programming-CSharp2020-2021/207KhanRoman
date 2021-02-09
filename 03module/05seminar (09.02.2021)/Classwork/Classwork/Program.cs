using System;
using System.Collections.Generic;
namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            LinkedList<int> list = new LinkedList<int>();

            int p = x;
            while (p>0)
            {
                list.AddFirst(p%10);
                p /= 10;
            }

            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine();
            Stack<int> stack = new Stack<int>();
            p = x;
            while (p > 0)
            {
                stack.Push(p % 10);
                p /= 10;
            }
            foreach (int i in stack)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
