using DDD.Application;
using DDD.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace DDD.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class BooksController(LibraryDbContext context, BorrowBookHandler borrowBookHandler, IMemoryCache cache) : ControllerBase
{
    private readonly LibraryDbContext _context = context;
    private readonly BorrowBookHandler _borrowBookHandler = borrowBookHandler;
    private readonly IMemoryCache _cache = cache;

    [HttpGet]
    public IActionResult GetBooks()
    {
        if (_cache.TryGetValue("allBooks", out string booksDataString))
            return Ok(JsonConvert.DeserializeObject<IEnumerable<Domain.Book>>(booksDataString)); // Return cached data
        var books = _context.Books.ToList();
        _cache.Set("allBooks", JsonConvert.SerializeObject(books), TimeSpan.FromSeconds(10));
        return Ok(books);
    }

    [HttpPost("{id}/borrow")]
    public IActionResult BorrowBook(Guid id)
    {
        try
        {
            _borrowBookHandler.Handle(id);
            return Ok(new { Message = "Book borrowed successfully." });
        }
        catch (ArgumentException ex)
        {
            return NotFound(new { ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { ex.Message });
        }
    }
}
