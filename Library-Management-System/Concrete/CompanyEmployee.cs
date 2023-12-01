using Library_Management_System.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class CompanyEmployee : Member
    {
        public CompanyEmployee(string name, string surname) : base(name, surname)
        {

        }
    }
}
