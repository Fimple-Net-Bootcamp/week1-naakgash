using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class Journal : Publication
    {
        public int IssueNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PublishFrequencyInMonths { get; set; }
        public Journal(string title, string publisher, int pages,int issueNumber, DateTime releaseDate, int publishFrequencyInMonths)
            : base(title, publisher, pages)
        {
            IssueNumber = issueNumber;
            ReleaseDate = releaseDate;
            PublishFrequencyInMonths = publishFrequencyInMonths;

        }
    }
}
