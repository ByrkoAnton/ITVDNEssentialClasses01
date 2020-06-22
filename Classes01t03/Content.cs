using System;
using System.Collections.Generic;
using System.Text;

namespace Classes01t03
{
    class Content
    {
        private string content;

        public Content()
        {
            content = "none";
        }

        public void Add(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine(content);
        }
    }
}
