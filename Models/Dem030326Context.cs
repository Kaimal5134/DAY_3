using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WinFormsApp1.Models;

public partial class Dem030326Context : DbContext
{
    public Dem030326Context()
    {
    }

    public Dem030326Context(DbContextOptions<Dem030326Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Library> Libraries { get; set; }

    public virtual DbSet<RelisedBook> RelisedBooks { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=91.222.238.6;username=rover_user;password=root123;database=dem03.03.26", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Idauthors).HasName("PRIMARY");

            entity.ToTable("authors");

            entity.Property(e => e.Idauthors).HasColumnName("idauthors");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Idbooks).HasName("PRIMARY");

            entity.ToTable("books");

            entity.HasIndex(e => e.AuthorId, "author_idx");

            entity.Property(e => e.Idbooks).HasColumnName("idbooks");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.NameBook)
                .HasMaxLength(45)
                .HasColumnName("name_book");
            entity.Property(e => e.PriceBook)
                .HasPrecision(10, 2)
                .HasColumnName("price_book");

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("author");
        });

        modelBuilder.Entity<Library>(entity =>
        {
            entity.HasKey(e => e.IdLibrary).HasName("PRIMARY");

            entity.ToTable("libraries");

            entity.Property(e => e.IdLibrary).HasColumnName("id_library");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Secname)
                .HasMaxLength(45)
                .HasColumnName("secname");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<RelisedBook>(entity =>
        {
            entity.HasKey(e => e.IdrelisedBooks).HasName("PRIMARY");

            entity.ToTable("relised_books");

            entity.HasIndex(e => e.CodeBook, "code_book_idx");

            entity.HasIndex(e => e.CodeLibrary, "code_library_idx");

            entity.HasIndex(e => e.CodeStudent, "code_student_idx");

            entity.Property(e => e.IdrelisedBooks).HasColumnName("idrelised_books");
            entity.Property(e => e.CodeBook).HasColumnName("code_book");
            entity.Property(e => e.CodeLibrary).HasColumnName("code_library");
            entity.Property(e => e.CodeStudent).HasColumnName("code_student");
            entity.Property(e => e.Date).HasColumnName("date");

            entity.HasOne(d => d.CodeBookNavigation).WithMany(p => p.RelisedBooks)
                .HasForeignKey(d => d.CodeBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("code_book");

            entity.HasOne(d => d.CodeLibraryNavigation).WithMany(p => p.RelisedBooks)
                .HasForeignKey(d => d.CodeLibrary)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("code_library");

            entity.HasOne(d => d.CodeStudentNavigation).WithMany(p => p.RelisedBooks)
                .HasForeignKey(d => d.CodeStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("code_student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.IdStudents).HasName("PRIMARY");

            entity.ToTable("students");

            entity.Property(e => e.IdStudents).HasColumnName("id_students");
            entity.Property(e => e.Class)
                .HasMaxLength(45)
                .HasColumnName("class");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Secname)
                .HasMaxLength(45)
                .HasColumnName("secname");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
