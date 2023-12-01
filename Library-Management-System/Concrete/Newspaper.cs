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
        public int PublishFrequencyInMonths { get; set; }
        public int MyProperty { get; set; }
        public Newspaper(string title, string publisher, int pages, DateTime publicationDate)
            : base(title, publisher, pages)
        {
            PublicationDate = publicationDate;
        }
    }
}
