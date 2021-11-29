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
            Figure round = new Round(1, 8, 13, "Yellow");
            Figure ring = new Ring(4, 6, 8, 12);
            List<Figure> figures = new();
            figures.Add(line);
            figures.Add(circle);
            figures.Add(rectangle);
            figures.Add(round);
            figures.Add(ring);
            foreach (var figure in figures)
            {
                Console.WriteLine(Fogure.Draw())
            }
        }
    }
}
