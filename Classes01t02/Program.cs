using System;

namespace Classes01t02
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA, sideB;
            Console.Write("side A=");
            sideA = double.Parse(Console.ReadLine());
            Console.Write("side B=");
            sideB = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(sideA, sideB);
            Console.WriteLine($"Arrea={rectangle.Area}");
            Console.WriteLine($"Perim={rectangle.Perimetr}");
        }
    }
}
