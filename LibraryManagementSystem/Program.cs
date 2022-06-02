// See https://aka.ms/new-console-template for more information


using LibraryManagementSystem;

Console.WriteLine("Hello, Welcome to our library");
Console.WriteLine("Select operation");
Console.WriteLine("1 Add Books");
Console.WriteLine("2 Display books by id");
Console.WriteLine("3 View all books");
Console.WriteLine("4 delete books");
Console.WriteLine("5 search book by author");
Console.WriteLine("6 search book by title");
Console.WriteLine("Press 'x' to exit");

var userInput = Console.ReadLine();
var bookLibrary = new BookLibrary();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Enter Id");
            int bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Author");
            var author = Console.ReadLine();

            var newBook = new Book(bookId, title,author);
            bookLibrary.AddBook(newBook);
            break;

        case "2":
            Console.WriteLine("enter book to search:");
            var searchBookById = int.Parse(Console.ReadLine());
            bookLibrary.DisplayBooks(searchBookById);
            break;

        case "3":
            bookLibrary.DisplayAllBooks();
            break;

        case "4":
            Console.WriteLine("enter book to search:");
            var deletebookbyid = int.Parse(Console.ReadLine());
            bookLibrary.DeleteBooks(deletebookbyid);
            Console.WriteLine("Book has been successfully deleted");
            break;

        case "5":
            Console.WriteLine("Enter author");
            var findbookbyauthor = Console.ReadLine();
            bookLibrary.SearchBookByAuthor(findbookbyauthor);
            break;

        case "6":
            Console.WriteLine("Enter Title");
            var findbookbytitle = Console.ReadLine();
            bookLibrary.SearchBookByTitle(findbookbytitle);
            break;

        case "x":
            return;

        default:
            Console.WriteLine("Select valid operation");
            break;
    }

    Console.WriteLine("Select operation");
    userInput = Console.ReadLine();
}


