namespace Mission11_Underwood.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}