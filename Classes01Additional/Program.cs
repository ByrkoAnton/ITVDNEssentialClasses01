using System;

namespace Classes01Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            Adderss adderss = new Adderss();

            Console.WriteLine(adderss.Index + "\n" + adderss.Country + "\n" + adderss.City +
                "\n" + adderss.Street + "\n" + adderss.House + "\n" + adderss.Apartment);

            adderss.Index = "01234";
            adderss.Country = "US";
            adderss.City = "NY";
            adderss.Street = "Main street";
            adderss.House = "16";
            adderss.Apartment = "337";

            Console.WriteLine(adderss.Index + "\n" + adderss.Country + "\n" + adderss.City +
                "\n" + adderss.Street + "\n" + adderss.House + "\n" + adderss.Apartment);
        }
    }
}
