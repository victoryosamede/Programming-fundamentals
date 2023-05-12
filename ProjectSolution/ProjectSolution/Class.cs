using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Class
    {
        public string Identifier { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Class(string identifier)
        {
            Identifier = identifier;
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
    }
}
