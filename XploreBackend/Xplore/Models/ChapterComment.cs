namespace Xplore.Models
{
    public class ChapterComment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Parentid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Chapter Chapter { get; set; }
        public User CommentAuthor { get; set; }
    }
}
