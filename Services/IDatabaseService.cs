using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Services
{
    public interface IDatabaseService
    {
        public Author AddAuthor(string name, string surname);
        public Book AddBook(string title, Author author);
        public void PopulateDatabase();
    }
}
