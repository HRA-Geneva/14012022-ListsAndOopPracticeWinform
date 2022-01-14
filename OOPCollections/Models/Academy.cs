using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollections.Models
{
    internal class Academy
    {
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }

        public Academy(string name)
        {
            Name = name;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Groups = new List<Group>();
        }


        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }


        public void AddStudent(Student student)
        {
            Students.Add(student);

            //TODO add students to all entitis

        }
    }
}
