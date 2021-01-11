using Microsoft.EntityFrameworkCore;

namespace WombatLibrarianApi.Models
{
    public class WombatBooksContext : DbContext
    {
        public WombatBooksContext(DbContextOptions<WombatBooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Wishlist> WishlistItems { get; set; }
        public DbSet<Bookshelf> BookshelfItems { get; set; }
    }
}
