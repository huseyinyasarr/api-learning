using BookDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDemo.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        var books = ApplicationContext.Books.ToList();
        return Ok(books);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOneBook(int id)
    {
        var book = ApplicationContext.Books.Where(x => x.Id.Equals(id)).SingleOrDefault();

        if (book is null)
            return NotFound();

        return Ok(book);
    }

}
