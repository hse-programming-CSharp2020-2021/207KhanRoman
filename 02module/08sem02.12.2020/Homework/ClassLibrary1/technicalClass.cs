using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    class TechnicalClass
    {
        /// <summary>
        /// Метод для Task01
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int GetIntValue(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
    }
}
