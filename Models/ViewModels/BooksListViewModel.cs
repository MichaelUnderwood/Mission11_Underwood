namespace Mission11_Underwood.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}