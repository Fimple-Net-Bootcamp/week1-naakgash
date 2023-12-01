using Library_Management_System.Concrete;
using Library_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Abstract
{
    internal abstract class Member : IPrintable
    {
        public int ID { get; } = 0 ;
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Publication> BorrowedPublicationList { get; set; }
        public Member(string name, string surname)
        {
            ID++;
            Name = name;
            Surname = surname;
            BorrowedPublicationList = new List<Publication>();
        }
        public void Print()
        {
            
        }

        public void Borrow(Publication publication)
        {
            if (!publication.isBorrowed)
            {
                this.BorrowedPublicationList.Add(publication);
                publication.isBorrowed = true;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is already borrowed.");
            }

        }

        public void Return(Publication publication)
        {
            if (publication.isBorrowed)
            {
                this.BorrowedPublicationList.Remove(publication);
                publication.isBorrowed = false;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book is not borrowed.");
            }
        }
    }
}
