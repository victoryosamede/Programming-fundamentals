using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public Student(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
