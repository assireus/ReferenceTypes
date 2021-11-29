using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure line = new Line(1, 1, 5, 8);
            Figure circle = new Circle(1, 2, 5);
            Figure rectangle = new Rectangle(1, 0, 5, 12);
            Figure round = new Round(1, 5, 9, "Yellow");
            Figure ring = new Ring(3, 5, 7, 11);
            List<Figure> figures = new();
            figures.Add(line);
        }
    }
}
