using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstAPI.Models;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public BookStoreController(BookStoreContext context)
        {
            _context = context;
            
        }

        // GET: api/GetBooks
        [HttpGet("GetBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }
        /* // GET: BookStore
         public async Task<IActionResult> Index()
         {
               return View(await _context.Book.ToListAsync());
         }*/

        // GET: api/GetBook
        [HttpGet("GetBook/{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Book.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // GET: api/GetAuthors
        [HttpGet("GetAuthors")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await _context.Author.ToListAsync();
        }

        // GET: api/GetAuthor
        [HttpGet("GetAuthor/{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await _context.Author.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        // GET: api/GetBooksByAuthor
        [HttpGet("GetBooksByAuthor/{id}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthor(int id)
        {
            var books = await _context.Book.Where(b => b.Author.Id == id).ToListAsync();

            if (books == null)
            {
                return NotFound();
            }

            return books;
        }
    }
}
