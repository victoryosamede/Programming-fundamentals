using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_14
{
    public class StudentTest
    {
        private static Student[] createdStudents = new Student[1];
        private static Student[]students = new Student[createdStudents.Length]; 
        
        public static void Main()
        {
            Student student1 = new Student("Victory Uhunmwangho", "Computer Science", "uvictory0@gmail.com", 08132138698);
            Student student2 = new Student();
            Student student3 = new Student();
            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
        public static Student[] CreatedStudents { get { return createdStudents; } }

        public static void CreateStudent(string name, string course, string email, ulong phoneNumber)
        {


            for (int i = 0; i < createdStudents.Length; i++)
            {
                Array.Copy(students, createdStudents, students.Length);

                if (createdStudents.Length > 1)
                {
                    i = createdStudents.Length - 1;
                }

                Student student = new Student(name, course, email, phoneNumber);
                createdStudents[i] = student;
                Console.WriteLine("Student Created");
            }
            var v = students.Length + 1;
            students = new Student[v];
            Array.Copy(createdStudents, students, createdStudents.Length);
            var t = createdStudents.Length + 1;
            createdStudents = new Student[t];
            
        }
         
         
    }
}
