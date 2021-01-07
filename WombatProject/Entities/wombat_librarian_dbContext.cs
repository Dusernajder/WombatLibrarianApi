using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WombatLibrarianApi.Entities
{
    public partial class wombat_librarian_dbContext : DbContext
    {
        public wombat_librarian_dbContext()
        {
        }

        public wombat_librarian_dbContext(DbContextOptions<wombat_librarian_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthorJunction> BookAuthorJunctions { get; set; }
        public virtual DbSet<Bookshelf> Bookshelves { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryBookJunction> CategoryBookJunctions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=wombat_librarian_db;Username=judi;Password=1964");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Description)
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.Language)
                    .HasColumnType("character varying")
                    .HasColumnName("language");

                entity.Property(e => e.MaturityRating)
                    .HasColumnType("character varying")
                    .HasColumnName("maturityRating");

                entity.Property(e => e.PageCount).HasColumnName("pageCount");

                entity.Property(e => e.Published)
                    .HasColumnType("character varying")
                    .HasColumnName("published");

                entity.Property(e => e.Publisher)
                    .HasColumnType("character varying")
                    .HasColumnName("publisher");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RatingCount).HasColumnName("ratingCount");

                entity.Property(e => e.Subtitle)
                    .HasColumnType("character varying")
                    .HasColumnName("subtitle");

                entity.Property(e => e.Thumbnail)
                    .HasColumnType("character varying")
                    .HasColumnName("thumbnail");

                entity.Property(e => e.Title)
                    .HasColumnType("character varying")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<BookAuthorJunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("book_author_junction");

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.BookId)
                    .HasColumnType("character varying")
                    .HasColumnName("bookId");

                entity.HasOne(d => d.Author)
                    .WithMany()
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("book_author_junction_authorId_fkey");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("book_author_junction_bookId_fkey");
            });

            modelBuilder.Entity<Bookshelf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookshelf");

                entity.Property(e => e.BookId)
                    .HasColumnType("character varying")
                    .HasColumnName("bookId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("bookshelf_bookId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("bookshelf_userId_fkey");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CategoryBookJunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("category_book_junction");

                entity.Property(e => e.BookId)
                    .HasColumnType("character varying")
                    .HasColumnName("bookId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("category_book_junction_bookId_fkey");

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("category_book_junction_categoryId_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HashedPass)
                    .HasColumnType("character varying")
                    .HasColumnName("hashedPass");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wishlist");

                entity.Property(e => e.BookId)
                    .HasColumnType("character varying")
                    .HasColumnName("bookId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Book)
                    .WithMany()
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("wishlist_bookId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("wishlist_userId_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
