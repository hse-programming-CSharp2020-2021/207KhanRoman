using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class LatString : MyStrings
    {
        public LatString(char start, char finish, int n) : base(start, finish, n)
        {
            // проверяем количество символов строки и допустимые границы
            Validate(n, start, finish);
        }
        /// <summary>
        /// Свойство, возвращающее информацию о палиндромности
        /// </summary>
        new public bool IsPalindrome
        {
            get
            {
                return IsPalindrome();
            }
        }

        /// <summary>
        /// метод подсчитывает количество вхождений символа в строку
        /// </summary>
        /// <param name="letter">буква, которая ищется в строке</param>
        /// <returns></returns>
        public override int CountLetter(char letter)
        {
            if (letter < 'a' || letter > 'z') return 0;
            return base.CountLetter(letter);
        }


        public override bool Validate(int n, char start, char finish)
        {
            if (n <= 0 || start < 'a' || finish > 'z')
                throw new ArgumentOutOfRangeException();
            return true;
        }
    }
}
