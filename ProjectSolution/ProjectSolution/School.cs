using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class School
    {
        public List<Class> Classes { get; set; }

        public School()
        {
            Classes = new List<Class>();
        }
    }
}
