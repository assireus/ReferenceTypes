using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Line : Figure
    {
        public Line(int x, int y, int endx, int endy) : base(x,y)
        {
            EndX = endx;
            EndY = endy;
        }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public override string Draw()
        {
            return string.Format("Объект линия:\nНачало ({0};{1}))\n", X, Y, EndX, EndY);
        }
    }
}
