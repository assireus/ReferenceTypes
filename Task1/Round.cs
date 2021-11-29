using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Round : Circle
    {
        public Round(int x, int y, int radius, string color) : base(x, y)
        {
            Color = color;
        }
        public string Color { get; set; }
        public override string Draw()
        {
            return string.Format("Объект круг:\nЦентр круга ({0};{1}))\nРадиус: {2}\nЦвет: {3}", X, Y, Radius, Color);
        }
    }
}
