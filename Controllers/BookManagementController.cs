using BookManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private static readonly List<Book> books = new()
    {
        new Book
        {
            Id = 1,
            Title = "Clean Code",
            Author = "Robert C. Martin",
            Price = 500
        },
        new Book
        {
            Id = 2,
            Title = "The Pragmatic Programmer",
            Author = "Andrew Hunt",
            Price = 600
        }
    };

    // GET: api/books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        return Ok(books);
    }

    // GET: api/books/1
    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            return NotFound("Book not found");
        }

        return Ok(book);
    }

    // POST: api/books
    [HttpPost]
    public IActionResult CreateBook(Book book)
    {
        book.Id = books.Max(x => x.Id) + 1;

        books.Add(book);
        //trying to return the created resource by internally calling GetBookById method
        return CreatedAtAction(
            nameof(GetBookById),
            new { id = book.Id },
            book);
    }

    // PUT: api/books/1
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book updatedBook)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            return NotFound("Book not found");
        }

        book.Title = updatedBook.Title;
        book.Author = updatedBook.Author;
        book.Price = updatedBook.Price;

        return Ok(book);
    }

    // DELETE: api/books/1
    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = books.FirstOrDefault(x => x.Id == id);

        if (book == null)
        {
            return NotFound("Book not found");
        }

        books.Remove(book);

        return NoContent();
    }
}
