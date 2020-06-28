using System;

namespace Classes01t04
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1,3), new Point(3,5), new Point(6,7), new Point(10,20));
            figure.ShowDescription();
        }
    }
}
