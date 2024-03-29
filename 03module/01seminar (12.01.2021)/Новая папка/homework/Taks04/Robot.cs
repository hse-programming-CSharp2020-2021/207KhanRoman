﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Taks04
{
    class Robot
    {
        // класс для представления робота
        public int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }
}
