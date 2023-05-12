using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Book
    {
        private string? title;
        private string? author;
        private string? publisher;
        private DateTime releaseDate;
        private int iSBNNumber;

        public Book()
        {

        }
        public Book(string title, string author, string publisher, DateTime releaseDate, int iSBNNumber) 
        { 
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.iSBNNumber= iSBNNumber;
        }

         

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set 
            { 
                this.author = value;
            }
        }
        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            set
            {
                this.publisher = value;
            }
        }
        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }
        public int ISBNNumber
        {
            get
            {
               return this.iSBNNumber;
            }
            set
            {
                this.iSBNNumber = value;
            }
        }

    }
}
