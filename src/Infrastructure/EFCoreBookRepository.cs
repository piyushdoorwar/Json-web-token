using DDD.Domain;

namespace DDD.Infrastructure;

public class EFCoreBookRepository(LibraryDbContext context) : IBookRepository
{
    private readonly LibraryDbContext _context = context;

    public Book GetById(Guid id)
    {
        return _context.Books.Find(id);
    }

    public void Save(Book book)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
    }
}

