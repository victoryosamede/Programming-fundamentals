using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_14
{
    public class Student
    {
        private string fullName = null;
        private string course = null;
        private string email = null;
        private ulong phoneNumber = 0L;
        private static int StudentCount = 0;
        enum Subject { };
        enum Universities { };
        public Student():this(null)
        {
           
        }
        public Student(string name): this(name, null)
        {

        }
        public Student(string name, string course): this(name, course, null) 
        {
             
        }
        public Student(string name, string course, string email): this(name, course, email, 0)
        {

        }
        public Student(string name, string course, string email, ulong phoneNumber) 
        {
            this.FullName = name;
            this.course = course;
            this.email = email;
            this.phoneNumber = phoneNumber;
            StudentCount = +1; //?????????????
        }

        public string FullName
        {
            get { return this.fullName; }
            set 
            {
                if (value == "Guy") throw new Exception();
                this.fullName = value; 
            }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public ulong PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                this.phoneNumber = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student name is {0}, course : {1}, email: {2}, phonenumber: {3}", FullName, Course, Email, PhoneNumber);
        }
           
    }
}
