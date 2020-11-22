using System;
// Извиняюсь, но я не понял как именно надо создавать эти классы в задании, поэтому я немного сымпровизировал.

namespace MyLabForTask01
{
    public class A
    {
        public string Value { get; set; }
        public A() { }
        public A(string str)
        {
            Value = str;
        }
        public virtual void getA ()
        {
            Console.WriteLine(Value);
        }
    }
    public class B : A
    {
        public int ValueInt { get; set; }
        public B (int x)
        {
            ValueInt = x;
        }
        public override void getA()
        {
            Console.WriteLine(ValueInt);
        }
    }
}
