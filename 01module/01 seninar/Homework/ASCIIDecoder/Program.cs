using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите Ваш код: ");
        int Code = int.Parse(Console.ReadLine());
        Console.WriteLine("Символ с Вашим кодом в таблице ASCII - " + (char)Code);
    }
}
