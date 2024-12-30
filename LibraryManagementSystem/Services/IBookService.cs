using System.Collections;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services
{
    public interface IBookService
    {
        // Add a new book to the library
        void AddBook(Book book);

        // Delete a book from the library by its ID
        void DeleteBook(int bookID);

        // Update details of an existing book
        void UpdateBook(Book book);

        // Retrieve a book by its ID
        Book GetBookById(int id);

        // Get all books in the library
        IEnumerable GetAllBooks();
    }
}
