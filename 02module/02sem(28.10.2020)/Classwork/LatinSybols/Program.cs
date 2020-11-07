using System;
//1.Определить класс LatinChar с полем _char и свойством доступа к нему, значение поля – символ латинского алфавита.
//Значение поля по умолчанию – ‘a’. Определить конструкторы класса.
//В основной программе создать объект типа LatinChar и,
//последовательно перебирая все символы из заданного пользователем диапазона [minChar,  maxChar], 
//выводить значение поля _char объекта.
namespace LatinSybols
{
    class LatinChar
    {
        private char _char;
        public char Char
        {
            get
            {
                return _char;
            }
        }
        public LatinChar()
        {
            _char = 'a';
        }
        public LatinChar(char newChar)
        {
            _char = newChar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LatinChar l;
            char minChar = Console.ReadKey().KeyChar;
            char maxChar = Console.ReadKey().KeyChar;
            for (int i = minChar; i<=maxChar; i++)
            {
                l = new LatinChar((char)i);
                Console.WriteLine("Символ: " + l.Char);
            }
        }
    }
}
