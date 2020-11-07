using System;
using System.Threading;

namespace Classwork
{
    class Program
    {
        public static void Write (char[][][] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = new char[1][];
                int count = 2;
                for (int j = chars[i].Length - 1; j > -1; j--)
                {

                    chars[i][j] = new char[count];
                    for (int q = 0; q < count; q++)
                    {
                        Console.WriteLine($"{j}-ый блок");
                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[][][] chars = new char[3][][];
            for (int i = 0; i<chars.Length;i++)
            {
                chars[i] = new char[1][];
                int count = 2;
                for (int j = chars[i].Length - 1; j > -1; j--)
                {
                    
                    chars[i][j] = new char[count];
                    for (int q = 0; q<count;q++)
                    {
                        chars[i][j][q] = (char)rnd.Next('a', 'z');
                    }
                    count++;
                }
            }
            Write(chars);
        }
    }
}
