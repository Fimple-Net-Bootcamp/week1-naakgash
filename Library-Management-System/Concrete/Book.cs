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
        internal string Author { get; set; }
        internal Book(string title, string author, string publisher, int pages)
        : base(title, publisher, pages)
        {
            Author = author;
        }
        public override void Print()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publication Date: {PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Pages: {Pages}");
            Console.WriteLine($"Borrowed: {isBorrowed}");
        }

    }
}
