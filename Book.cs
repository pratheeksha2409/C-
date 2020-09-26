using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoreApp
{
    class Book
    {
        int id, price;
        string author, title;


        public int BooksID
        {
            get { return id; }
            set { id = value; }
        }

        public string BooksAuthor
        {
            get { return author; }
            set { author = value; }
        }

        public string BooksTitle
        {
            get { return title; }
            set { title = value; }
        }

        public int BooksPrice
        {
            get { return price; }
            set { price = value; }
        }



        static void Main(string[] args)
        {
            Book book = new Book();
            book.BooksID = 20;
            book.BooksTitle = "C #";
            book.BooksAuthor = "Pratheeksha";
            book.BooksPrice = 450;
            Console.WriteLine($" Book is {book.BooksTitle} ...id is {book.BooksID}.. written by {book.BooksAuthor}.. cost is {book.BooksPrice}");

        }
    }
}