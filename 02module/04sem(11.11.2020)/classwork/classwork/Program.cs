using System;
using System.Reflection.PortableExecutable;

namespace classwork
{
    class Person
    {
        public string Fio { get; set; }
        public DateTime Birthdate { get; set; }
        public bool IsMale { get; set; }

        public Person (string f, DateTime d, bool m)
        {
            Fio = f;
            Birthdate = d;
            IsMale = m;
        }
        public virtual void ShowInfo ()
        {
            Console.WriteLine($"{Fio}  {Birthdate}  {IsMale}");
        }

    }
    class Employee : Person
    {
        public string CompanyName { get; set; }
        public string Post { get; set; }
        public string Schedule { get; set; }
        public decimal Salary { get; set; }
        public Employee(string f, DateTime d, bool m, string name, string post, string sch, decimal sal) : base(f, d, m)
        {
            CompanyName = name;
            Post = post;
            Schedule = sch;
            Salary = sal;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Fio}\t{Birthdate}\t{IsMale}\t{CompanyName}\t{Post}\t{Schedule}\t{Salary}");
        }
    }
    class Student : Person
    {
        public string Institute { get; set; }
        public string Spec { get; set; }
        public Student(string f, DateTime d, bool m, string inst, string spex) : base(f,d,m)
        {
            Institute = Institute;
            Spec = spex;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Fio}  {Birthdate}  {IsMale} {Institute} {Spec}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("fdsfsd", new DateTime(2000,01,01), true);
            Student stud = new Student("fdsfsd", new DateTime(2000, 01, 01), true, "fdsfds", "sfsdfs");
            Employee em = new Employee("fdsfsd", new DateTime(2000, 01, 01), true, "comp", "post", "sch", 2);
            per.ShowInfo();
            stud.ShowInfo();
            em.ShowInfo();

            Person[] pers = new Person[3];
            pers[0] = per;
            pers[1] = stud;
            pers[2] = em;
            for (int i = 0; i<pers.Length; i++)
            {
                pers[i].ShowInfo();
            }
        }
    }
}
