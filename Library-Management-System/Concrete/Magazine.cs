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
    }
}
