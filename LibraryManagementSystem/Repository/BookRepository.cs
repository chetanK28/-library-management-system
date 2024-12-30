using MySql.Data.MySqlClient;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using System.Collections;
using System.Data;

namespace LibraryManagementSystem.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly string connectionString;

        public BookRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddBook(Book book)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    var command = new MySqlCommand("INSERT INTO Books (Title, ISBN, Genre, TotalCopies, AvailableCopies) VALUES (@Title, @ISBN, @Genre, @TotalCopies, @AvailableCopies)", connection);
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.Parameters.AddWithValue("@Genre", book.Genre);
                    command.Parameters.AddWithValue("@TotalCopies", book.TotalCopies);
                    command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DeleteBook(int bookID)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    var command = new MySqlCommand("DELETE FROM Books WHERE BookID = @BookID", connection);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public IEnumerable GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    var command = new MySqlCommand("SELECT * FROM Books", connection);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                ISBN = reader.GetString("ISBN"),
                                Genre = reader.IsDBNull("Genre") ? null : reader.GetString("Genre"),
                                TotalCopies = reader.GetInt32("TotalCopies"),
                                AvailableCopies = reader.GetInt32("AvailableCopies")
                            };
                            books.Add(book);
                        }
                    }
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }
            }
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = null;
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    var command = new MySqlCommand("SELECT * FROM Books WHERE BookID = @BookID", connection);
                    command.Parameters.AddWithValue("@BookID", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            book = new Book
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader.GetString("Title"),
                                ISBN = reader.GetString("ISBN"),
                                Genre = reader.IsDBNull("Genre") ? null : reader.GetString("Genre"),
                                TotalCopies = reader.GetInt32("TotalCopies"),
                                AvailableCopies = reader.GetInt32("AvailableCopies")
                            };
                        }
                    }
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }
            }
            return book;
        }

        public void UpdateBook(Book book)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    var command = new MySqlCommand("UPDATE Books SET Title = @Title, AuthorID = @AuthorID, PublisherID = @PublisherID, ISBN = @ISBN, Genre = @Genre, TotalCopies = @TotalCopies, AvailableCopies = @AvailableCopies WHERE BookID = @BookID", connection);
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.Parameters.AddWithValue("@Genre", book.Genre);
                    command.Parameters.AddWithValue("@TotalCopies", book.TotalCopies);
                    command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies);
                    command.Parameters.AddWithValue("@BookID", book.BookID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
