using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Rectangle : Line
    {
        public Rectangle(int x, int y, int endx, int endy) : base(x, y, endx, endy)
        {

        }
        public override string Draw()
        {
            return string.Format("Объект прямоугольник:\nширина ({0};{1}))\n", Math.Abs(EndX - X), Math.Abs(EndY - Y));
        }
    }
}
