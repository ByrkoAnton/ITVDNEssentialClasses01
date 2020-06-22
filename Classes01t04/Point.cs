using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Classes01t04
{
    class Point
    {
        private int x;
        private int y;
        private string description; //я не понял для чего это поле по условию нужно, но пусть хранит координаты точек в строке

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            description = "x=" + x.ToString() + ", y=" + y.ToString() + "\n";
        }
        public int GetX
        {
            get
            {
                return x;
            }
        }

        public int GetY
        {
            get
            {
                return y;
            }
        }

        public string GetDrscription
        {
            get
            {
                return description;
            }
        }

    }
}
