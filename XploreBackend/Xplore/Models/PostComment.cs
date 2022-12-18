namespace Xplore.Models
{
    public class PostComment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Parentid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Post Post { get; set; }

    }
}
 