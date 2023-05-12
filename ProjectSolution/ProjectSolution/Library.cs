using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Library
    {
        private string name;
        private List<Book> books;

        public Library(string name, List<Book> books)
        {
            this.name = name;
            this.books = books;
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SearchByAuthor(string author)
        {
            List<Book> booksByAuthor = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                     booksByAuthor.Add(book);
                }
            }
            Console.WriteLine($"These are the list of books written by {author}: ");
            foreach(Book book in booksByAuthor)
            {
                Console.WriteLine(book.Title);
            }
        }
        public void DisplayInfo(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Release Date: {book.ReleaseDate}, ISBN-number: {book.ISBNNumber}");
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

    }
}
