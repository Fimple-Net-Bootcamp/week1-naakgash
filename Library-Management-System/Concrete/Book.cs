using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class Book : Publication
    {
        public string Author { get; set; }
        public Book(string title, string author, string publisher, int pages)
        : base(title, publisher, pages)
        {
            Author = author;
        }

    }
}
