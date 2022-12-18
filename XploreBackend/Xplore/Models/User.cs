using System.ComponentModel.DataAnnotations;
using Xplore.Enums;

namespace Xplore.Models
{
    public class User
    {

        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; }
        public string About { get; set; } = String.Empty;
        public DateTime Dob { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<ChapterComment> Comments { get; set; }
        public ICollection<BookList> BookLists { get; set; } 
        

    }
}
