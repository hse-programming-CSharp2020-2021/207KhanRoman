using System;

namespace task02
{
    // хлеб
    class Bread
    {
        public int Weight { get; set; } // масса

        public static Sandwich operator + (Bread a, Butter b)
        {
            return new Sandwich();
        }
    }

    // масло
    class Butter
    {
        public int Weight { get; set; } // масса

    }

    // бутерброт
    class Sandwich
    {
        public int Weight { get; set; } // масса
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Bread() + new Butter());
        }
    }
}
