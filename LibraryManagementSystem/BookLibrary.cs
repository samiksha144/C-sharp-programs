using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookLibrary
    {
        private string find;

        List<Book> books { get; set; } = new List<Book>();

        public void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"Book: {book.BookId},{book.Author}, {book.Title}, {book.Created}");
        }

        public void DisplayBookDetails(List<Book> books)
        {
            foreach(var book in books)
            {
                DisplayBookDetails(book);
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks(int BookId)
        {
            var book = books.FirstOrDefault(x => x.BookId == BookId);
            if(book == null)
            {
                Console.WriteLine("Book not found");
            }

            else
            {
                DisplayBookDetails(book);
            }
        }


        public void DisplayAllBooks()
        {
            foreach (var book in books)
            {
                DisplayBookDetails(book);
            }
        }

        public void DeleteBooks(int BookId)
        {
            books.RemoveAll(Book => Book.BookId == BookId );
           
        }

        public void SearchBookByAuthor(string Author)
        {
            var book = books.FirstOrDefault(x => x.Author == Author);
            if (book == null)
            {
                Console.WriteLine("Book not found");
            }

            else
            {
                DisplayBookDetails(book);
            }
        }

        public void SearchBookByTitle(string Title)
        {
            var book = books.FirstOrDefault(x => x.Title == Title);
            if (book == null)
            {
                Console.WriteLine("Book not found");
            }

            else
            {
                DisplayBookDetails(book);
            }
        }

    }
}
