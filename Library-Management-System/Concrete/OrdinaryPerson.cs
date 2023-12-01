using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class OrdinaryPerson : Member
    {
        public OrdinaryPerson(string name, string surname) : base(name, surname)
        {

        }
    }
}
