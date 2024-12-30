using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System.Collections;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(string title, string isbn, string genre, int totalCopies, int availableCopies)
        {
            Book book = new Book(title, isbn, totalCopies, availableCopies, genre);

            if (ModelState.IsValid)
            {
                bookService.AddBook(book);
                return RedirectToAction("GetAllBooks");
            }
            return View(book);
        }

        public IActionResult GetAllBooks()
        {
            IEnumerable books = bookService.GetAllBooks();
            return View(books);
        }

        [HttpPost]
        public IActionResult DeleteBook(int id)
        {
            bookService.DeleteBook(id);
            return RedirectToAction("GetAllBooks");
        }

        public IActionResult EditBook(int id)
        {
            var book = bookService.GetBookById(id);

            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                bookService.UpdateBook(book);
                return RedirectToAction("GetAllBooks");
            }
            return View(book);
        }
    }
}
