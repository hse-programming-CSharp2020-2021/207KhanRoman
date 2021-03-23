using System;

namespace ефыл03
{
    class Arrays<T>
    {
        T[] array = default(T[]);
        public void Add(T element)
        {
            T[] newArray = default(T[]);
            array.CopyTo(newArray, array.Length);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arrays<int> intArr = new Arrays<int>();
        }
    }
}
