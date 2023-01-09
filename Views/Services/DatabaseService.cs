using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FirstAPI.Views.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly BookStoreContext _context;

        public DatabaseService(BookStoreContext context)
        {
            _context = context;
        }

        public Author AddAuthor(string name, string surname)
        {
            var author = new Author(name, surname);
            _context.Add(author);

            return author;
        }

        public Book AddBook(string title, Author author)
        {
            var book = new Book(title, author);
            _context.Add(book);

            return book;
        }

        public void PopulateDatabase()
        {
            Console.WriteLine("Populating database");

            var author1 = AddAuthor("Jonas", "Jonaitis");
            var author2 = AddAuthor("Petras", "Petraitis");
            var author3 = AddAuthor("Simas", "Simaitis");

            AddBook("Book 1", author1);
            AddBook("Book 2", author1);
            AddBook("Book 3", author2);
            AddBook("Book 4", author3);
            AddBook("Book 5", author2);
            AddBook("Book 6", author3);
            _context.SaveChanges();
        }
    }
}
