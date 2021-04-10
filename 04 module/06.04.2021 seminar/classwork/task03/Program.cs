using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace task03
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }
    [Serializable]
    public class Professor : Human
    {
        public Professor(string name) : base(name) { }
        public Professor() { }
    }

    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }
        List<Human> staff;
        public List<Human> Staff { get { return staff; } }
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
        public override string ToString()
        {
            string text = $"Departament - {DeptName}\nHumans:\n";
            try
            {
                foreach (Human hum in Staff)
                {
                    text += $"{hum.Name}\n";
                }
            }
            catch
            {

            }
            return text;
        }
    }


    [Serializable]
    public class University
    {
        public string UniversityName { get; set; }
        public List<Dept> Departments { get; set; }

        public override string ToString()
        {
            string text = $"University - {UniversityName}\nDepertaments:\n";
            foreach (Dept dept in Departments)
            {
                text += $"{dept}\n";
            }
            return text;
        }
        public University() { }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            University[] univs = new University[2];
            for (int i = 0; i<2; i++)
            {
                univs[i] = UniversityGen();
            }

            XmlSerializer bf = new XmlSerializer(typeof(University[]), new Type[] { typeof(University), typeof(Human), typeof(Professor), typeof(Dept) });
            File.Delete("MyFile.bin");
            using (FileStream fl = new FileStream("MyFile.xml", FileMode.OpenOrCreate))
            {
                bf.Serialize(fl, univs);
            }

            University[] univs2;
            using (FileStream fl = new FileStream("MyFile.xml", FileMode.Open))
            { 
                univs2 = (University[])(bf.Deserialize(fl));
            }

            Array.ForEach(univs2, x => Console.WriteLine(x));
        }
        public static string NameGen()
        {
            string str = "";
            for (int i = 0; i < rnd.Next(6, 20); i++)
                str += (char)rnd.Next('a', 'z');
            return str;
        }
        private static University UniversityGen()
        {
            University newUniversity = new University();
            List<Dept> depts = new List<Dept>();
            for (int j = 0; j < rnd.Next(2, 11); j++) {
                Human[] humans = new Human[rnd.Next(5, 400)];
                for (int i = 0; i < humans.Length; i++)
                {
                    if (rnd.Next(0, 2) == 0)
                        humans[i] = new Human(NameGen());
                    else
                        humans[i] = new Professor(NameGen());
                }
                depts.Add(new Dept(NameGen(), humans));
            }
            newUniversity.Departments = depts;
            newUniversity.UniversityName = NameGen();
            return newUniversity;
        }
    }
}
