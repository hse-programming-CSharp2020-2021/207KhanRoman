using System;

namespace TechnicalLub
{

    public class TechnicalClass
    {
        public delegate bool Condition(double n);
        public static double Validate(string text, Condition n)
        {
            double x;
            bool error = false;
            do
            {
                if (error) Console.WriteLine("Введена фигня, попробуйте еще раз!");
                Console.Write(text);
                error = true;
            } while (!(double.TryParse(Console.ReadLine(), out x) && n.Invoke(x)));
            return x;
        }

        public static char[] WayParseAndValidate(string a)
        {
            char[] commandsArray = a.ToCharArray();
            if (Array.Exists(commandsArray, x => x != 'R' && x != 'L' && x != 'F' && x != 'B')) throw new ArgumentException("Невверный набор комманд!");
            return commandsArray;
        }

        public static void MatrixPrint(string[,] matrix)
        {
            for (int i = 0; i<matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    if (matrix[i, j] == "+ ") Console.ForegroundColor = ConsoleColor.Gray;
                    else if (matrix[i, j] == "* ") Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
