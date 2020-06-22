using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t03
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            author.Show();

            Console.ForegroundColor = ConsoleColor.Green;
            title.Show();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            content.Show();

            Console.ResetColor();
        }

        public void AddTitle(string title)
        {
            this.title.Add(title);
        }

        public void AddAuthor(string author)
        {
            this.author.Add(author);
        }

        public void AddContent(string content)
        {
            this.content.Add(content);
        }
    }
}
