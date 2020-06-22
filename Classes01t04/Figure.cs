using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t04
{
    class Figure
    {
        Point p1;
        Point p2;
        Point p3;
        Point p4;
        Point p5;
        private string name { get; }

        public Figure(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);

            p4 = null;
            p5 = null;
            name = "Triangle";
        }

        public Figure(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
            p4 = new Point(x4, y4);

            p5 = null;
            name = "Quadrangle";
        }

        public Figure(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
            p4 = new Point(x4, y4);
            p5 = new Point(x5, y5);
            name = "Pentagon";
        }

        private double GetLenghtSide(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.GetX - p1.GetX, 2) + Math.Pow(p2.GetY - p1.GetY, 2));
        }

        public double GetPerimetr()
        {
            if (p4 == null)
                return GetLenghtSide(p1, p2) + GetLenghtSide(p2, p3) + GetLenghtSide(p1, p3);

            if (p5 == null)
                return GetLenghtSide(p1, p2) + GetLenghtSide(p2, p3) + GetLenghtSide(p3, p4) + GetLenghtSide(p4, p1);

            return
                GetLenghtSide(p1, p2) + GetLenghtSide(p2, p3) + GetLenghtSide(p3, p4) + GetLenghtSide(p4, p5) + GetLenghtSide(p5, p1);
        }

        public void ShowDescription()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Perim={GetPerimetr()}");
        }
    }
}
