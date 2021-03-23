using System;
using System.IO;

namespace Classwork
{
    class Program
    {
        static void Main()
        {

            BinaryWriter fOut = new BinaryWriter(
            new FileStream("../../../t.dat", FileMode.Create));

            for (int i = 0; i <= 10; i += 2)
                fOut.Write(i);
            fOut.Close();

            FileStream f = new FileStream("../../../t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }
            Console.WriteLine("\nЧисла в обратном порядке:");

            // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
            f.Position = f.Length - 4;
            for (int i = 0; i < fIn.BaseStream.Length / sizeof(int); i++)
            {
                n = fIn.ReadInt32();
                if (f.Position >= 8)
                    f.Position -= 8;
                else
                    f.Position = 0;

                Console.Write(n + " ");
            }

            // 2) TODO: увеличить  все числа в файле в 5 раз
            
            BinaryWriter bw = new BinaryWriter(f);
            for (int i = 0; i < fIn.BaseStream.Length / sizeof(int); i++)
            {
                a = fIn.ReadInt32();
                f.Seek(i * 4, SeekOrigin.Begin);
                bw.Write(5 * a);
            }

            // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
            fIn.BaseStream.Position = 0;
            for (int i = 0; i < fIn.BaseStream.Length / sizeof(int); i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }

            fIn.Close();
            f.Close();
        }
    }
}
