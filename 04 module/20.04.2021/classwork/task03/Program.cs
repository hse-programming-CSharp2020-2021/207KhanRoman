using System;

namespace task03
{
    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        public static State operator + (State a, State b)
        {
            return new State() { Area = a.Area+b.Area, Population = a.Population+b.Population}
        }
        public static bool operator > (State a, State b)
        {
            return a.Area > b.Area ? true : false;
        }
        public static bool operator <(State a, State b)
        {
            return a.Area <= b.Area ? true : false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();
            State state3 = state1 + state2;
            bool isGreater = state1 > state2;
        }
    }
}
