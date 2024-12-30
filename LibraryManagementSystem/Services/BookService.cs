using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Services;
using System.Collections;

namespace LibraryManagementSystem.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            bookRepository.AddBook(book);
        }

        public void DeleteBook(int bookID)
        {
            bookRepository.DeleteBook(bookID);
        }

        public IEnumerable GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public void UpdateBook(Book book)
        {
            bookRepository.UpdateBook(book);
        }
    }
}
