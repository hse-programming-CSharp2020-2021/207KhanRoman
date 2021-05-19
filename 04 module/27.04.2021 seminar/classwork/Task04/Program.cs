using System;
using System.Collections;

namespace Task04
{
    class RandomEnumerator : IEnumerator
    {
        Random rnd = new Random();
        int current = 0;
        int count = 0;
        int maxCount;
        public RandomEnumerator(int n)
        {
            maxCount = n;
        }
        public object Current => current;

        public bool MoveNext()
        {
            if (count > maxCount) return false;
            current = rnd.Next();
            count++;
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
    class RandomCollection : IEnumerable
    {
        int count;
        public RandomCollection(int n)
        {
            count = n;
        }
        public IEnumerator GetEnumerator()
        {
            return new RandomEnumerator(count);
        }
        public IEnumerator GetEnumerator(int n)
        {
            count = n;
            return new RandomEnumerator(count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomCollection rnd = new RandomCollection(10);
            foreach (int memb in rnd)
                Console.WriteLine(memb + " ");
        }
    }
}
