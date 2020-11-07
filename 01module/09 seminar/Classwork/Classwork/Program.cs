using System; // Для доступа к классу Console

using System.IO; // Для работы с файлами и директориями

namespace Directories
{​​​​​

    class Program
    {​​​​​

       

        static void Main(string[] args)
        {​​​​​

       // Блок try-catch при работе с файлами обязателен!

            try
            {​​​​​

                DirectoryOverview(@"..\..\..\");

            }​​​​​

            catch (…) {​​​​​

                …

            }​​​​​

      Console.WriteLine("Нажмите любую клавишу, чтобы выйти");

            Console.ReadLine();

            }​​​​​

    }​​​​​

}​​​​​
