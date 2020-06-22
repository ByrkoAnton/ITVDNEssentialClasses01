using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t03
{
    class Title
    {
        private string title;

        public Title()
        {
            title = "none";
        }

        public void Add(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine(title);
        }
    }
}
