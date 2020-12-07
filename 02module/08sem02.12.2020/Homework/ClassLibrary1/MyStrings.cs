using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public abstract class MyStrings
    {
        public string str;
        public static Random rnd = new Random();

        public MyStrings(char start, char finish, int n)
        {
            char[] letters = new char[n];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)rnd.Next(start, finish + 1);
            }
            str = new String(letters);
        }
        public bool IsPalindrome()
        {
            if (str.Length > 0)
            {
                char[] tmp = str.ToCharArray();
                Array.Reverse(tmp);
                string tmpString = new string(tmp);
                if (str.CompareTo(tmpString) == 0) return true;
            }
            return false;
        }
        public abstract bool Validate(int n, char start, char finish);
        public override string ToString()
        {
            return str;
        }
        public virtual int CountLetter(char letter)
        {
            int start = 0, result = -1, res;
            do
            {
                res = str.IndexOf(letter, start);
                start = res + 1;    // начало следующего поиска 
                result++;           // счетчик вхождений
            } while (res >= 0);
            return result;
        }
    }
}
