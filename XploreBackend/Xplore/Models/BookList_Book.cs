namespace Xplore.Models
{
    public class BookList_Book
    {
        public int BookListId { get; set; }
        public BookList BookList { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        
    }

}
