using System;

namespace Task08
{
    class Schedule
    {
        string[] daysName = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
        public string this[int index]
        {
            get
            {
                if (index < 1 || index > 7) throw new Exception("Неверное значение");
                return daysName[index - 1];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule day = new Schedule();
            for (int i = 1; i<8; i++)
            {
                Console.WriteLine("Название дня недели: " + day[i]);
            }
        }
    }
}
