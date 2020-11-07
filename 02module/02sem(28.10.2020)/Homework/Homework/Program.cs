using System;

namespace task01
{
    class Birthday
    {
        string name;
        int year, month, day; 
        public Birthday(string name, int y, int m, int d)
        { 
            this.name = name;
            year = y; month = m; day = d;
        }
        public Birthday()
        {
            year = 1970;
            day = 1;
            month = 1;
            name = "Иван";
        }
        DateTime Date
        { 
            get { return new DateTime(year, month, day); }
        }
        public string BirthdayKnow1 ()
        {
            return Date.ToString("dd.MMMM.yyyy");
        }
        public string BirthdayKnow2()
        {
            return Date.ToString("dd.mm.yy");
        }
        public string Information
        {   
            get
            {
                return name + ", дата рождения " + day + ":" + month + ":" + year;
            }
        }
        public int HowManyDays
        {
            get
            {
                int dayOfYear = DateTime.Now.DayOfYear;
                int dayOfBirthDay = Date.DayOfYear;
                return (365 - dayOfYear + dayOfBirthDay) % 365;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Birthday md = new Birthday("Чапаев", 1887, 2, 9);
            Console.WriteLine(md.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(md.HowManyDays);
            Console.WriteLine(md.BirthdayKnow1());
            Console.WriteLine(md.BirthdayKnow2());

            Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
            Console.WriteLine(km.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(km.HowManyDays);
            Console.WriteLine(km.BirthdayKnow1());
            Console.WriteLine(km.BirthdayKnow2());

            Birthday defoltPerson = new Birthday();
            Console.WriteLine(defoltPerson.BirthdayKnow1());
            Console.WriteLine(defoltPerson.BirthdayKnow2());
        }
    }
}
