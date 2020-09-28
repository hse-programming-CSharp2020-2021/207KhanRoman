using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            // ~a - делает инверсию в битовом представлении
            // sbite - знаковый [-128,127] (1-разряд - прямой код, все остальные - доп. код), bite [0,255]

            // пример:
            sbyte a1 = -17;
            sbyte b1 = (sbyte)~a1;
            Console.WriteLine(b1);

            // побитовые операции.
            sbyte a = 17;
            sbyte b = 25;
            Console.WriteLine(a^b);
            Console.WriteLine(a | b);
            Console.WriteLine(a & b);

            // Побитовые сдвиги
            sbyte a2 = 6;
            sbyte b2 = -25;
            Console.WriteLine((sbyte)(a2 >> 2));
            Console.WriteLine((sbyte)(a2 << 5));
            Console.WriteLine((sbyte)(b2 >> 1));
            Console.WriteLine((sbyte)(b2 << 1));
        }
    }
}
