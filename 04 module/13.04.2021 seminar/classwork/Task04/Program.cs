using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Drawing;

namespace Task04
{
    [DataContract]
    [Serializable]
    public class ConsoleSimbol
    {
        [DataMember]
        int x;
        [DataMember]
        int y;
        [DataMember]
        char simb;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public char Simb
        {
            get
            {
                return simb;
            }
            set
            {
                simb = value;
            }
        }
        public ConsoleSimbol(int x, int y, char simb)
        {
            this.x = x;
            this.y = y;
            this.simb = simb;
        }
        public ConsoleSimbol() { }

        public override string ToString()
        {
            return $"({X}, {Y}), {Simb}";
        }
    }

    [DataContract]
    [Serializable]
    public class ColorConsoleSimbol : ConsoleSimbol
    {
        [DataMember]
        public Color Color { get; set; }
        public ColorConsoleSimbol (int x, int y, char simb, Color color) : base(x,y,simb)
        {
            Color = color;
        }
        public ColorConsoleSimbol() { }

        public override string ToString()
        {
            return base.ToString() + $"{Color}";
        }
    }
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green };
            ConsoleSimbol[] arr = new ConsoleSimbol[rnd.Next(10)];
            ColorConsoleSimbol[] arrColor = new ColorConsoleSimbol[rnd.Next(10)];
            ConsoleSimbol[] arr2;
            ColorConsoleSimbol[] arrColor2;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new ConsoleSimbol(rnd.Next(0, 100), rnd.Next(0, 100), (char)rnd.Next('a', 'z'));
            }
            for (int i = 0; i < arrColor.Length; i++)
            {
                arrColor[i] = new ColorConsoleSimbol(rnd.Next(0, 100), rnd.Next(0, 100), (char)rnd.Next('a', 'z'), colors[rnd.Next(3)]);
            }

            // Бинарка.
            Console.WriteLine("Сериализуем ConsoleSimbol");
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("ser.bin", FileMode.Create))
            {
                bf.Serialize(fs, arr);
            }
            using (FileStream fs = new FileStream("ser.bin", FileMode.Open))
            {
                arr2 = (ConsoleSimbol[])bf.Deserialize(fs);
            }
            Array.ForEach(arr2, x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Сериализуем ColorConsoleSimbol");
            using (FileStream fs = new FileStream("serColor.bin", FileMode.Create))
            {
                bf.Serialize(fs, arrColor);
            }
            using (FileStream fs = new FileStream("serColor.bin", FileMode.Open))
            {
                arrColor2 = (ColorConsoleSimbol[])bf.Deserialize(fs);
            }
            Array.ForEach(arrColor2, x => Console.WriteLine(x));
            Console.WriteLine();

            // XML.
            Console.WriteLine("Сериализуем ConsoleSimbol");
            XmlSerializer xs = new XmlSerializer(typeof(ConsoleSimbol[]));
            using (FileStream fs = new FileStream("ser.xml", FileMode.Create))
            {
                
                bf.Serialize(fs, arr);
            }
            using (FileStream fs = new FileStream("ser.xml", FileMode.Open))
            {
                arr2 = (ConsoleSimbol[])bf.Deserialize(fs);
            }
            Array.ForEach(arr2, x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Сериализуем ColorConsoleSimbol");
            XmlSerializer xsColor = new XmlSerializer(typeof(ColorConsoleSimbol[]));
            using (FileStream fs = new FileStream("serColor.xml", FileMode.Create))
            {

                xsColor.Serialize(fs, arrColor);
            }
            using (FileStream fs = new FileStream("serColor.xml", FileMode.Open))
            {
                arrColor2 = (ColorConsoleSimbol[])xsColor.Deserialize(fs);
            }
            Array.ForEach(arrColor2, x => Console.WriteLine(x));
            Console.WriteLine();

            // Json.
            Console.WriteLine("Сериализуем ConsoleSimbol");
            string data = JsonSerializer.Serialize<ConsoleSimbol[]>(arr);
            arr2 = JsonSerializer.Deserialize<ConsoleSimbol[]>(data);
            Array.ForEach(arr2, x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Сериализуем ColorConsoleSimbol");
            string dataColor = JsonSerializer.Serialize<ColorConsoleSimbol[]>(arrColor);
            arrColor2 = JsonSerializer.Deserialize<ColorConsoleSimbol[]>(dataColor);
            Array.ForEach(arrColor2, x => Console.WriteLine(x));
            Console.WriteLine();

            // DataContract.
            Console.WriteLine("Сериализуем ConsoleSimbol");
            var serializer = new DataContractSerializer(typeof(ConsoleSimbol[]));
            using (FileStream fs = new FileStream("ser.xml", FileMode.Create))
            {
                serializer.WriteObject(fs, arr);
            }
            using (FileStream fs = new FileStream("ser.xml", FileMode.Open))
            {
                arr2 = (ConsoleSimbol[])serializer.ReadObject(fs);
            }
            Array.ForEach(arr2, x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Сериализуем ColorConsoleSimbol");
            var serializerColor = new DataContractSerializer(typeof(ColorConsoleSimbol[]), new Type[] { typeof(ColorConsoleSimbol[]) });
            using (FileStream fs = new FileStream("serColor.xml", FileMode.Create))
            {
                serializerColor.WriteObject(fs, arrColor);
            }
            using (FileStream fs = new FileStream("serColor.xml", FileMode.Open))
            {
                arrColor2 = (ColorConsoleSimbol[])serializerColor.ReadObject(fs);
            }
            Array.ForEach(arrColor2, x => Console.WriteLine(x));
            Console.WriteLine();
        }
    }
}
