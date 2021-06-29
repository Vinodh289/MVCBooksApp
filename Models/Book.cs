using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBooksApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookGenre { get; set; }

        public List<Book> getBooksList()
        {
            List<Book> bookList = new List<Book>();
            Book book1 = new Book();
            book1.BookId = 1; book1.BookTitle = "A"; book1.BookAuthor = "A1"; book1.BookGenre = "Fiction";
            bookList.Add(book1);
            Book book2 = new Book();
            book2.BookId = 2; book2.BookTitle = "B"; book2.BookAuthor = "B1"; book2.BookGenre = "Fiction";
            bookList.Add(book2);
            Book book3 = new Book();
            book3.BookId = 3; book3.BookTitle = "C"; book3.BookAuthor = "C1"; book3.BookGenre = "Fiction";
            bookList.Add(book3);
            Book book4 = new Book();
            book4.BookId = 4; book4.BookTitle = "D"; book4.BookAuthor = "D1"; book4.BookGenre = "Biography";
            bookList.Add(book4);
            return bookList;
        }
    }
}