using System;
using System.IO;
/*
1)    ArgumentException
2)    InvalidOperationException
3)    NullReferenceException
4)    ArgumentNullException
5)  FormatException
6)  DivideByZeroException
7)  IOException
 */

namespace classwork
{
    class my
    {

    }
    class Program
    {
        public static void ArgMethod (int x)
        {
            if (x < 0) throw new ArgumentException();
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            try
            {
                ArgMethod(-5);

                a[3] = null;
                int b = a[6];


                int.Parse(null);


                a[1] = 0;
                b = 2 / a[1];


                string s = File.ReadAllText("sdfsd.fdsf");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
