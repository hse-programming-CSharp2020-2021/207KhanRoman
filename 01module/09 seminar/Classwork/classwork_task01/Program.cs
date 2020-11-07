using System;
using System.IO;

namespace classwork_task01
{
    class Program
    {
        public static void DirectoryOverview (string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            while (Directory.Exists(path))
            {
                Console.WriteLine(dir.GetFiles());
                Console.WriteLine(dir.Attributes);
                Console.WriteLine(dir.CreationTime);
                Console.WriteLine(dir.LastAccessTime);
                path -= path.Replace"../";
            }           
        }
        static void Main(string[] args)
        {
            try {
                DirectoryOverview(@"..\..\..\");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadKey();
        }
    }
}
