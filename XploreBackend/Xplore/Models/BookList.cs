namespace Xplore.Models
{
    public class BookList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public ICollection<BookList_Book>? BookList_Books { get; set; }
    }
}
