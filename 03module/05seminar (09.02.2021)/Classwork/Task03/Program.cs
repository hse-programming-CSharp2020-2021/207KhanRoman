/*
Организовать очередь на посадку пассажиров в транспорт. Очередь пассажиров (класс PassengerQueue) реализовать с использованием обобщённой очереди Queue<T>. 
В программе предусмотреть два типа пассажиров: обычный пассажир (класс Passenger) и пассажир с детьми (PassengerWithChildren)
Passenger 
Поля: строковые: имя и фамилия; целочисленное возраст
Свойства 
Для чтения и записи значений полей имени (состоит не более чем из 30 только латинских символов и пробелов, начинается с заглавной буквы) и фамилии (состоит не более чем из 40 только латинских символов и пробелов и тире, начинается с заглавной буквы) 
Автореализуемое IsOld логическое, открытое только для чтения, возвращает true для пассажира старше 65 лет
Переопределённый метод ToString() возвращает строку с данными о пассажире
PassengerWithChildren наследует из класса Passenger
Поля: целочисленной количество детей;
Свойства
Для чтения и записи поля о количестве детей (не менее одного, но не более 40)
Автореализуемое IsNewBorn, логическое, открытое только для чтения, возвращает true для пассажиров с младенцами
Переопределённый метод ToString() возвращает строку с данными о пассажире
PassengerQueue
Поля: две обобщённые очереди ordinaryQueue для обычных пассажиров и priorityQueue для приоритетных. Приоритет имеют пассажиры с младенцами и пассажиры старше 65 лет
Методы:
Открытый метод AddToQueue(), определяющий автоматически очередь, в которую поставить пассажира
Открытый метод StartServingQueue(), запускающий обслуживание очереди. Если в приоритетной очереди три и меньше пассажиров, они обслуживаются первыми, если больше то через одного с обычной очередью.
В основной программе считайте данные о пассажирах и файла csv, продумайте его структуру самостоятельно, считайте, что файл достаточно велик, чтобы не помещаться в память. Распределите пассажиров по очереди, запустите обработку. Интерфейс с пользователем для просмотра пассажиров в очередях продумайте и реализуйте самостоятельно
Для решения задачи можно добавлять дополнительные члены класса
Заготовки для классов и некоторые дополнительные требования ищете на следующих слайдах
 
*/

using System;
using System.Collections.Generic;

namespace A
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
        string name;
        string lastName;
        int age;
        public bool IsOld { private set; get; }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public int Age
        {
            set
            {
                if (value < 0) throw new ArgumentException("Все плохо");
                age = value;
                if (age > 65) IsOld = true;
            }
            get { return age; }
        }
        public override string ToString()
        {
            return $"{Name} {LastName}; age - {Age}";
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        int numberOfChildren;
        public bool IsNewBorn { private set; get; }
        public int NumberOfChildren
        {
            set
            {
                if (value < 0) throw new ArgumentException("Все плохо");
                numberOfChildren = value;
            }
            get { return numberOfChildren; }
        }
        public override string ToString()
        {
            return base.ToString() + $"; IsNewBorn {IsNewBorn}; NumberOfChildren {NumberOfChildren}";
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            int n = 0;
            while (ordinaryQueue.Count + priorityQueue.Count != 0)
            {
                if (priorityQueue.Count <= 3 && priorityQueue.Count != 0)
                {
                    Console.WriteLine(priorityQueue.Peek());
                    priorityQueue.Dequeue();
                }
                if (n == 0 && priorityQueue.Count!=0)
                {
                    Console.WriteLine(priorityQueue.Peek());
                    priorityQueue.Dequeue();
                }
                else if (ordinaryQueue.Count != 0)
                {
                    Console.WriteLine(ordinaryQueue.Peek());
                    ordinaryQueue.Dequeue();
                }
                n = (n + 1) % 2;
            }
        }
    }

    class MainClass
    {
        static Random rnd = new Random();
        public static void Main()
        {
            PassengerQueue queue = new PassengerQueue();
            for (int i = 0; i < rnd.Next(10,20); i++)
            {
                Passenger pass;

                if (rnd.Next(0, 2) == 1)
                {
                    pass = new Passenger();
                    pass.Name = rnd.Next(0, 100000000).ToString();
                    pass.LastName = rnd.Next(0, 100000000).ToString();
                    pass.Age = rnd.Next(0, 100);
                    queue.AddToQueue(pass);
                }
                else
                {
                    pass = new PassengerWithChildren();
                    pass.Name = rnd.Next(0, 100000000).ToString();
                    pass.LastName = rnd.Next(0, 100000000).ToString();
                    pass.Age = rnd.Next(0, 100);
                    ((PassengerWithChildren)pass).NumberOfChildren = rnd.Next(0, 20);
                    queue.AddToQueue(pass);
                }
                queue.StartServingQueue();
            }

        }
    }
}
