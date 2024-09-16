using BookDemo.Data;
using BookDemo.Models;
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

    [HttpPost]
    public IActionResult SetOneBook(Book book)
    {
        try
        {
            if (book is null)
                return BadRequest();

            else
            {
                ApplicationContext.Books.Add(book);
                return StatusCode(201, book);
            }
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

}
