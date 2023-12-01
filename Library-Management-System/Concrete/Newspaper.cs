using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class Newspaper : Publication
    {
        public DateTime ReleaseDate { get; set; }
        public int PublishFrequencyInDays { get; set; }
        public int MyProperty { get; set; }
        public Newspaper(string title, string publisher, int pages, DateTime publicationDate)
            : base(title, publisher, pages)
        {
            PublicationDate = publicationDate;
        }
        public override void Print()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publication Date: {PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Pages: {Pages}");
            Console.WriteLine($"Publish Frequency In Days: {PublishFrequencyInDays}");
            Console.WriteLine($"Borrowed: {isBorrowed}");
        }
    }
}
