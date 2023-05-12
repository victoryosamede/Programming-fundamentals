using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
 public class Teacher
    {
        public string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name)
        {
            Name = name;
            Disciplines = new List<Discipline>();
        }
    }
}
