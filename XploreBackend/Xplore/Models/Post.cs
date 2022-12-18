namespace Xplore.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public User PostAuthor { get; set; }
        public ICollection<PostComment> PostComments { get; set; }
    }
}
