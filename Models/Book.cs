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
        public Author Author = new Author();
        public string BookGenre { get; set; }

     
        public List<Book> getBooksList()
        {
            List<Book> bookList = new List<Book>();
            Book book1 = new Book();
            
            book1.BookId = 1; book1.BookTitle = "A"; book1.Author.AuthorId = 1; book1.BookGenre = "Fiction";
            bookList.Add(book1);
            Book book2 = new Book();
            book2.BookId = 2; book2.BookTitle = "B"; book2.Author.AuthorId = 1; book2.BookGenre = "Fiction";
            bookList.Add(book2);
            Book book3 = new Book();
            book3.BookId = 3; book3.BookTitle = "C"; book3.Author.AuthorId = 2; book3.BookGenre = "Fiction";
            bookList.Add(book3);
            Book book4 = new Book();
            book4.BookId = 4; book4.BookTitle = "D"; book4.Author.AuthorId = 2; book4.BookGenre = "Biography";
            bookList.Add(book4);
            return bookList;
        }

        public void GetBooks(int AuthorId)
        {
            var listBooks = getBooksList();
            var listAuthors = GetAuthors();
            
           
            var query = (from book in listBooks
                        join author in listAuthors
                             on book.Author.AuthorId equals author.AuthorId
                             where book.Author.AuthorId==AuthorId
                        select new
                        {
                            book.BookTitle,
                            book.BookGenre,
                            author.AuthorName
                        }).ToList();
        }

        public List<Author> GetAuthors()
        {
            List<Author> authorList = new List<Author>();
            Author author = new Author();
            author.AuthorId = 1; author.AuthorName = "A";
            authorList.Add(author);
            return authorList;
        }

        
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }

}