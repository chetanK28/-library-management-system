using LibraryManagementSystem.Models;
using System.Collections;

namespace LibraryManagementSystem.Repositories
{
    public interface IBookRepository
    {
        // Add a new book to the library
        void AddBook(Book book);

        // Delete a book from the library by its ID
        void DeleteBook(int bookID);

        // Update the details of an existing book
        void UpdateBook(Book book);

        // Retrieve a book's details by its ID
        Book GetBookById(int id);

        // Get all books in the library
        IEnumerable GetAllBooks();
    }
}
