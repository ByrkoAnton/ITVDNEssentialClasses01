using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Classes01t02
{
    class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double _sideA, double _sideB)
        {
            sideA = _sideA;
            sideB = _sideB;
        }

        private double GetPerimetr(double sideA, double sideB)
        {
            return sideA * 2 + sideB * 2;
        }

        private double GetArea(double sideA, double sideB)
        {
            return sideA * sideB;
        }

        public double Area
        {
            get
            {
                return GetArea(sideA, sideB);
            }
        }

        public double Perimetr
        {
            get
            {
                return GetPerimetr(sideA, sideB);
            }
        }
    }
}
