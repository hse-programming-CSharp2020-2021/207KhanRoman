using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;

namespace Classwork
{
    class Program
    {
        public static string Number ()
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);

            int dx = 0;
            while (x > 2) {
                dx = dx * 10 + x % 2;
                x /= 2;
                Console.WriteLine(dx);
            }
            return dx.ToString();
        }
        static void Main(string[] args)
        {
            string n = Number();
            File.WriteAllText("intNumber.txt", n);
        }
    }
}
