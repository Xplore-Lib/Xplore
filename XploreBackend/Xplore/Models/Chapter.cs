namespace Xplore.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Blob { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Book Book { get; set; }
        public ICollection<ChapterComment> Comments { get; set; }
    }
}
