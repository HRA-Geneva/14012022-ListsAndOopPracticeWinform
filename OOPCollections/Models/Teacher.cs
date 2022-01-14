using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollections.Models
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(string name ,string surname)
        {
            Name = name;
            Surname = surname;
            Students = new List<Student>();
        }

    }
}
