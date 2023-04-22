using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace book_models.Models
{
    public partial class booklibraryContext : DbContext
    {
        public booklibraryContext()
        {
        }

        public booklibraryContext(DbContextOptions<booklibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__books__490D1AE1416F906E");

                entity.ToTable("books");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.CopiesInUse).HasColumnName("copies_in_use");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("isbn");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.TotalCopies).HasColumnName("total_copies");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}