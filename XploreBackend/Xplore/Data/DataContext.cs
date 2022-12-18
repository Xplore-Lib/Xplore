using Microsoft.EntityFrameworkCore;
using Xplore.Models;

namespace Xplore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BookList> BooksLists { get; set; }
        public DbSet<BookList_Book> BookListBooks { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<ChapterComment> ChaptersComments { get; set; }
        public DbSet<Post> Posts { get; set; }  
        public DbSet<PostComment> PostsComments { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChapterComment>()
                .HasOne<User>(u => u.CommentAuthor)
                .WithMany(c => c.Comments)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<BookList_Book>()
                .HasKey(a => new { a.BookId, a.BookListId});
            modelBuilder.Entity<BookList_Book>()
                .HasOne<Book>(b => b.Book)
                .WithMany(b => b.BookList_Books)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<BookList_Book>()
                .HasOne<BookList>(b => b.BookList)
                .WithMany(b => b.BookList_Books)
                .HasForeignKey(b => b.BookListId);
        } 
    }
}
