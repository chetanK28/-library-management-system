using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookID { get; set; } // Primary Key

        [Required]
        public string Title { get; set; } // Book Title


        [Required]
        [StringLength(20)]
        public string ISBN { get; set; } // Unique ISBN Number

        public string Genre { get; set; } // Genre of the Book

        [Required]
        public int TotalCopies { get; set; } // Total Copies in Library

        [Required]
        public int AvailableCopies { get; set; } // Available Copies for Borrowing

        // Default Constructor
        public Book() { }

        // Constructor for creating a new book
        public Book(string title, string isbn, int totalCopies, int availableCopies, string genre = null)
        {
            Title = title;
            ISBN = isbn;
            TotalCopies = totalCopies;
            AvailableCopies = availableCopies;
            Genre = genre;
        }

        // Constructor for updating an existing book
        public Book(int bookID, string title, string isbn, int totalCopies, int availableCopies, string genre = null)
        {
            BookID = bookID;
            Title = title;
            ISBN = isbn;
            TotalCopies = totalCopies;
            AvailableCopies = availableCopies;
            Genre = genre;
        }
    }
}
