using System;

namespace Task04
{
    struct Rectangle : IComparable
    {
        int a;
        int b;
        
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Square => a * b;

        public int CompareTo(object obj)
        {
            try
            {
                return Square.CompareTo(((Rectangle)obj).Square);
            }
            catch
            {
                throw new ArgumentException("Печально все");
            }
        }
    }
    class Block3D : IComparable
    {
        public Rectangle Footing { get; set; }
        double h;


        public Block3D(Rectangle footing, double h)
        {
            this.Footing = footing;
            this.h = h;
        }
        public int CompareTo(object obj)
        {
            if (obj as Block3D == null) throw new ArgumentException("Все плохо(");
            return Footing.CompareTo(((Block3D)obj).Footing);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(2, 8);
            Rectangle rect2 = new Rectangle(15, 10);
            Block3D block1 = new Block3D(rect1, 5);
            Block3D block2 = new Block3D(rect2, 65);

            Console.WriteLine(block2.CompareTo(block1));
        }
    }
}
