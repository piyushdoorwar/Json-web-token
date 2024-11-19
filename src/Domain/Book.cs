namespace DDD.Domain;

public class Book
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public bool IsAvailable { get; private set; }

    public Book(Guid id, string title)
    {
        Id = id;
        Title = title;
        IsAvailable = true;
    }

    public void Borrow()
    {
        if (!IsAvailable)
            throw new InvalidOperationException("Book is already borrowed.");

        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }
}
