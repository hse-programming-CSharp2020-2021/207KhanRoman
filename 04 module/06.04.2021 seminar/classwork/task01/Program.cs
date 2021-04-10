using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace classwork
{
    [Serializable]
    class Student
    {
        public string LastName { get; set; }
        public int Course { get; set; }

        public Student(string lastname, int course)
        {
            LastName = lastname;
            Course = course;
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] arr = new Student[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Student(LastNameGen(), rnd.Next(1, 5));
            }

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream("MyFile.bin", FileMode.OpenOrCreate))
            {
                bf.Serialize(fl, arr);
            }

            Student[] arr2;
            using (FileStream fl = new FileStream("MyFile.bin", FileMode.Open))
            {
                arr2 = (Student[])(bf.Deserialize(fl));
            }

            Array.ForEach(arr, x => Console.WriteLine($"{x.Course} {x.LastName}"));
        }

        public static string LastNameGen()
        {
            string str = "";
            for (int i = 0; i < rnd.Next(6, 20); i++)
                str += (char)rnd.Next('a', 'z');
            return str;
        }
    }
}