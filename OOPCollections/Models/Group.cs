using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCollections.Models
{
    internal class Group
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> Students { get; set; }

        public Group(string name,DateTime startDate,DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
