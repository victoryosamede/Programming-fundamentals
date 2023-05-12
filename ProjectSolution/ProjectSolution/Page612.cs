using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Page612
    {
        public static void Number20()
        {
            List<Book> books = new List<Book>
            {
                 
                new Book(title: "To kill a Mocking bird", author: "Harper Lee", publisher: "Packt publishing",iSBNNumber: 112344, releaseDate: DateTime.Now),
                new Book(title: "1984", author: "George Owell", publisher: "Oriell publishing", releaseDate: new DateTime(2023, 2, 5), iSBNNumber: 098764),
                new Book(title: "Pride and Prejudice", author: "Jane Austen", publisher: "Packt publishing", releaseDate: new DateTime(2023, 3, 9), iSBNNumber: 38388929),
                new Book(title: "Harry Potter and the Philosopher's stone", author: "J.K. Rowling", publisher: "Bloomsbury publishing", releaseDate: new DateTime(1997, 6, 26), iSBNNumber: 13344),
                new Book(title: "The Catcher in the Rye", author: "J.D Salinger", publisher: "Oriell publishing", releaseDate: new DateTime(1951, 7, 16), iSBNNumber: 29202)
            };
            Library cyphercrescentLibrary = new Library("cyphercrescentLibrary", books);
            Book newBook = new Book(title: "The Great Gatsby", author: "F. Scott Fitzgerald", publisher: "Bloomsbury publishing", releaseDate: new DateTime(2022, 5, 9), iSBNNumber: 990004);
            cyphercrescentLibrary.AddBook(newBook);
            foreach(Book book in books)
            {
                Console.WriteLine(book.Title);
            }
            cyphercrescentLibrary.SearchByAuthor("J.D Salinger");
             foreach(Book book in books)
            {
                cyphercrescentLibrary.DisplayInfo(book);
                 
            }
        }

        public static void Exercise22()
        {
            School school = new School();

            Class classA = new Class("Class A");

            Teacher teacher1 = new Teacher("John Doe");

            Discipline discipline1 = new Discipline
            {
                Name = "Math",
                NumberOfLessons = 5,
                NumberOfExercises = 10
            };

            teacher1.Disciplines.Add(discipline1);

            classA.Teachers.Add(teacher1);

            Student student1 = new Student("Alice", 1);

            classA.Students.Add(student1);

            school.Classes.Add(classA);

            Console.WriteLine("School Information:");
            foreach (var schoolClass in school.Classes)
            {
                Console.WriteLine("Class: " + schoolClass.Identifier);
                Console.WriteLine("Teachers:");
                foreach (var teacher in schoolClass.Teachers)
                {
                    Console.WriteLine("- " + teacher.Name);
                    Console.WriteLine("Disciplines Taught:");
                    foreach (var discipline in teacher.Disciplines)
                    {
                        Console.WriteLine("-- " + discipline.Name);
                        Console.WriteLine("--- Number of Lessons: " + discipline.NumberOfLessons);
                        Console.WriteLine("--- Number of Exercises: " + discipline.NumberOfExercises);
                    }
                }
                Console.WriteLine("Students:");
                foreach (var student in schoolClass.Students)
                {
                    Console.WriteLine("- " + student.Name + " (Number: " + student.Number + ")");
                }
            }

        }
        public static void Exercise25()
        {
            string input = "-3/4";
            Fraction fraction = Fraction.Parse(input);

            Console.WriteLine("Fraction: {0}/{1}", fraction.Numerator, fraction.Denominator);
            Console.WriteLine("Decimal Value: {0}", fraction.DecimalValue);
        }
    }
}
