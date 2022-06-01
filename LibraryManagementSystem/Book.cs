using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
  
    public class Book
    {
        public Book()
        {
        }

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Created = DateTime.Now;
           
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }

        
    }
}
