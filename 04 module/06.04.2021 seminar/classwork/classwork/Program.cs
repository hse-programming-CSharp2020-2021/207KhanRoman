using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task02
{
    [Serializable]
    class Student
    {
        public string LastName { get; set; }
        public int Course { get; set; }

        public Student (string lastname, int course)
        {
            LastName = lastname;
            Course = course;
        }
    }

    [Serializable]
    class Group
    {
        public int Number { get; set; }
        public List<Student> Students {get; set;}
        
        public Group (int n)
        {
            Number = n;
            Students = new List<Student>();
        }

        public override string ToString()
        {
            string text = $"Group - {Number}\nStudents:\n";
            foreach(Student stud in Students)
            {
                text += $"{stud.Course} {stud.LastName}\n";
            }
            return text;
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Group[] groups = new Group[2];
            for (int i = 0; i<2; i++)
            {
                groups[i] = GroupGen();
            }

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fl = new FileStream("MyFile.bin", FileMode.OpenOrCreate))
            {
                bf.Serialize(fl, groups);
            }

            Group[] groups2;
            using (FileStream fl = new FileStream("MyFile.bin", FileMode.Open))
            {
                groups2 = (Group[])(bf.Deserialize(fl));
            }

            Array.ForEach(groups2, x => Console.WriteLine(x));
        }

        private static Group GroupGen()
        {
            Group newGroup = new Group(rnd.Next(1, 301));
            for (int i = 0; i < rnd.Next(0, 32); i++)
            {
                newGroup.Students.Add(new Student(LastNameGen(), rnd.Next(1, 5)));
            }
            return newGroup;
        }

        public static string LastNameGen ()
        {
            string str = "";
            for (int i = 0; i < rnd.Next(6, 20); i++)
                str += (char)rnd.Next('a', 'z');
            return str;
        }
    }
}
