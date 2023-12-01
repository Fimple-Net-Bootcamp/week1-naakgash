using Library_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Abstract
{
    internal abstract class Publication: IPrintable
    {
        public int ID { get; } = 0 ;
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Pages { get; set; }
        public bool isBorrowed { get; set; }

        public Publication(string title, string publisher, int pages)
        {
            ID++;
            Title = title;
            Publisher = publisher;
            Pages = pages;
            isBorrowed = false;
        }

        public void Borrow()
        {
            if (!isBorrowed)
            {
                Console.WriteLine("Book borrowed successfully.");
                isBorrowed = true;
            }
            else
            {
                Console.WriteLine("Book is already borrowed.");
            }
        }

        public void Return()
        {
            if (isBorrowed)
            {
                Console.WriteLine("Book returned successfully.");
                isBorrowed = false;
            }
            else
            {
                Console.WriteLine("Book is not currently borrowed.");
            }
        }
    }

}
