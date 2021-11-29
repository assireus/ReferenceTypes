using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Circle : Figure
    {
        public Circle (int x, int y, int radius) : base(x,y)
        {
            Radius = Math.Abs(radius);
        }
        public int Radius { get; set; }
        public override string Draw()
        {
            return string.Format("Объект окружность:\nЦентр окружности ({0};{1}))\n", X, Y, Radius);
        }
    }
}
