using Library_Management_System.Abstract;
using Library_Management_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Concrete
{
    internal sealed class UniversityStudent : Member
    {
        public Universities University { get; set; }
        public UniversityStudent(Universities university, string name, string surname) : base(name, surname)
        {
            University = university;
        }
    }

}
