using DDD.Infrastructure;

namespace DDD.Application;

public class BorrowBookHandler(IBookRepository bookRepository)
{
    private readonly IBookRepository _bookRepository = bookRepository;

    public void Handle(Guid bookId)
    {
        var book = _bookRepository.GetById(bookId);
        book.Borrow();
        _bookRepository.Save(book);
    }
}
