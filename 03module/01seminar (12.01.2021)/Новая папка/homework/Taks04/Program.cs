using System;
using TechnicalLub;
using System.Text;

namespace Taks04
{
    delegate void Steps(); // делегат-тип

    class Program
    {
        public static int Lenght { get; set; }
        public static int Width { get; set; }

        public static void Main()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    Console.OutputEncoding = Encoding.GetEncoding("Unicode");
                    Lenght = (int)TechnicalClass.Validate("Укажите координату y: ", x => x == (int)x);
                    Width = (int)TechnicalClass.Validate("Укажите координату x: ", x => x == (int)x);

                    Robot rob = new Robot();    // конкретный робот
                    Steps delR = new Steps(rob.Right);      // направо
                    Steps delL = new Steps(rob.Left);       // налево
                    Steps delF = new Steps(rob.Forward);    // вперед
                    Steps delB = new Steps(rob.Backward);   // назад

                    Console.Write("Введите строку комманд: ");
                    char[] commandsStringArray = TechnicalClass.WayParseAndValidate(Console.ReadLine());

                    Steps[] trace = new Steps[commandsStringArray.Length];

                    for (int i = 0; i < trace.Length; i++)
                    {
                        switch (commandsStringArray[i])
                        {
                            case 'R':
                                trace[i] = delR;
                                break;
                            case 'L':
                                trace[i] = delL;
                                break;
                            case 'F':
                                trace[i] = delF;
                                break;
                            case 'B':
                                trace[i] = delB;
                                break;
                        }
                    }

                    string[,] matrix = MatrixGen();

                    for (int i = 0; i<trace.Length; i++)
                    {
                        matrix[Lenght - rob.y - 1, rob.x] = "+ ";
                        trace[i]?.Invoke();
                    }
                    matrix[Lenght - rob.y - 1, rob.x] = "* ";

                    TechnicalClass.MatrixPrint(matrix);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\nНажмите Escape, чтобы выйти, или любую другую клавишу, чтобы продолжыть");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static string[,] MatrixGen()
        {
            string[,] matrix = new string[Lenght, Width];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = "□ ";
                }
            }
            return matrix;
        }
    }
}