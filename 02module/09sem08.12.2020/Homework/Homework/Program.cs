using System;
using System.Text;

// Я не понял, что подразумевалось под "создайте строку из символов N десятичных цифр".
// Я создаю строку, в котором n символов десятичных цифр от 0 до 9. (простите, если сделал не то, но я пол часа пытался понять условие, но так и не смог).
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetInt.GetIntValue("Введите число: ");
            UserString number;
            try
            {
               
                number = new UserString(n, '0', '9');
                Console.WriteLine(number.ToString());
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        number.MoveOff(i.ToString());
                    }
                }
                Console.WriteLine(number.ToString());
            }
            catch
            {
                Console.WriteLine("Не получилось :(");
            }

        }
    }
}
