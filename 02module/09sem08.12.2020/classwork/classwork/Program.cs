using System;
using System.Text;

namespace classwork
{
    class Program
    {
        public static string ConvertHex2Bin1(string HexNumber)
        {
            int number = Convert.ToInt32(HexNumber, 2);
            return number.ToString("X1");
        }

        public static string SpaceDelete(string a)
        {
            StringBuilder b = new StringBuilder();
            return b.AppendJoin(' ', a.Split(), StringSplitOptions.RemoveEmptyEntries).ToString();
        }
        public static void ThirdWordsCount(string a)
        {
            string[] array = Array.FindAll(SpaceDelete(a).Split(), x => x.Length>3);
            Array.ForEach(array, x => Console.Write("\t" + x));
        }
        public static void VowelLetters(string a)
        {
            string[] array = Array.FindAll(SpaceDelete(a).Split(), x => x[0] >= 'A' & x[0]<'Z' || x[0] >= 'А' & x[0] < 'Я');
            Array.ForEach(array, x => Console.Write("\t" + x));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();

            Console.WriteLine(SpaceDelete(a));
            Console.WriteLine();
            ThirdWordsCount(a);
            Console.WriteLine();
            VowelLetters(a);
            Console.WriteLine();
            ConvertHex2Bin1(a);
        }
    }
}
