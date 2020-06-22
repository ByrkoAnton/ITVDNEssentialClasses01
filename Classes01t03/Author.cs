using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t03
{
    class Author
    {
        private string author;

        public Author()
        {
            author = "none";
        }

        public void Add(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine(author);
        }
    }
}
