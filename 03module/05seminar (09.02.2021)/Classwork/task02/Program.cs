using System;
using System.Collections.Generic;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] brackets = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i<brackets.Length; i++)
            {
                if (brackets[i] == '(') stack.Push('(');
                if (brackets[i] == ')') stack.Pop();
            }
            if (stack.Count == 0) Console.WriteLine("Последовательность правильная");
            else Console.WriteLine("Все плохо");
        }
    }
}
