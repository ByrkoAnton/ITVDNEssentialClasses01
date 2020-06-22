using System;

namespace Classes01t03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddAuthor("Troelsen");
            book.AddTitle("c#");
            book.AddContent("programing");
            book.Show();
        }
    }
}
