using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class Magazine : Publication
    {
        public DateTime ReleaseDate { get; set; }
        public int PublishFrequencyInMonths { get; set; }
        public Magazine(string title, string publisher, int pages, DateTime releaseMonth)
            : base(title, publisher, pages)
        {
            ReleaseDate = releaseMonth;
        }
        public override void Print()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publication Date: {PublicationDate.ToShortDateString()}");
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Pages: {Pages}");
            Console.WriteLine($"Publish Frequency In Months: {PublishFrequencyInMonths}");
            Console.WriteLine($"Borrowed: {isBorrowed}");
        }
    }
}
