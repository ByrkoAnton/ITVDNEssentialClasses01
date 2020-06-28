using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t04
{
    class Figure
    {
        Point[] p = new Point[5];

        private string name { get; }

        public Figure(Point p1, Point p2, Point p3)
        {
            p[0] = new Point(p1.GetX, p1.GetY);
            p[1] = new Point(p2.GetX, p2.GetY);
            p[2] = new Point(p3.GetX, p3.GetY);

            p[3] = null;
            p[4] = null;
            name = "Triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            p[0] = new Point(p1.GetX, p1.GetY);
            p[1] = new Point(p2.GetX, p2.GetY);
            p[2] = new Point(p3.GetX, p3.GetY);
            p[3] = new Point(p4.GetX, p4.GetY);

            p[4] = null;
            name = "Quadrangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            p[0] = new Point(p1.GetX, p1.GetY);
            p[1] = new Point(p2.GetX, p2.GetY);
            p[2] = new Point(p3.GetX, p3.GetY);
            p[3] = new Point(p4.GetX, p4.GetY);
            p[4] = new Point(p5.GetX, p5.GetY);

            name = "Pentagon";
        }

        private double GetLenghtSide(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.GetX - p1.GetX, 2) + Math.Pow(p2.GetY - p1.GetY, 2));
        }

        public double GetPerimetr()
        {
            if (p[3] == null)
                return GetLenghtSide(p[0], p[1]) + GetLenghtSide(p[1], p[2]) + GetLenghtSide(p[0], p[2]);

            if (p[4] == null)
                return GetLenghtSide(p[0], p[1]) + GetLenghtSide(p[1], p[2]) + GetLenghtSide(p[2], p[3]) + GetLenghtSide(p[3], p[0]);

            return
                GetLenghtSide(p[0], p[1]) + GetLenghtSide(p[1], p[2]) + GetLenghtSide(p[2], p[3]) + GetLenghtSide(p[3], p[4]) + GetLenghtSide(p[4], p[0]);
        }

        public void ShowDescription()
        {
            Console.WriteLine(name);
            Console.WriteLine($"Perim={GetPerimetr()}");
        }
    }
}
