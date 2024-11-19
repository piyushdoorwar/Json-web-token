using DDD.Domain;

namespace DDD.Infrastructure;

public interface IBookRepository
{
    Book GetById(Guid id);
    void Save(Book book);
}
