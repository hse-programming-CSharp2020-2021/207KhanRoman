﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class GetInt
    {
        public static int GetIntValue(string comment)
        {
            int intVal;
            do Console.Write(comment);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }
    }
}
