using Xplore.Enums;

namespace Xplore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Summary { get; set; }
        public Category? Category { get; set; }
        public string Tags { get; set; }
        public User BookAuthor { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public ICollection<BookList_Book>? BookList_Books { get; set; }
        public ICollection<Chapter>? Chapters { get; set; }
    }
}
