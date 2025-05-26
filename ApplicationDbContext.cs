using Library_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Borrower>? Borrowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MK41J4S\\SQLEXPRESS;Initial Catalog = LibraryContext;Integrated Security=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Author Model
            modelBuilder.Entity<Author>().Property(a => a.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Author>().HasData(
                new Author {Id=1 , Name = "Amr Mousa", DateOfBirth = new DateTime(2001, 7, 13) },
                new Author {Id =2 , Name = "Anas Emad", DateOfBirth = new DateTime(2001, 10, 5) },
                new Author {Id=3 ,Name = "Mohab Ayman", DateOfBirth = new DateTime(2000, 5, 4) }
                );


            // Book model
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(b => b.Genre).HasMaxLength(100);
            modelBuilder.Entity<Book>().HasOne(a => a.Author).WithMany(b => b.Books).HasForeignKey(b => b.AuthorId);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id =1, Title = "Don Quixote" , Genre = "Art" , PublishedDate =new DateTime(2022,5,7), AuthorId =1 },
                new Book { Id =2, Title = "Treasure Island", Genre = "Science Fiction", PublishedDate =new DateTime(2023,12,12), AuthorId = 1 },
                new Book { Id =3, Title = "Jane Eyre", Genre = "Historical", PublishedDate =new DateTime(2022,8,22), AuthorId = 1 },
                new Book { Id =4, Title = "Moby Dick", Genre = "Art", PublishedDate =new DateTime(2021,4,2), AuthorId = 2 },
                new Book { Id =5, Title = "Gulliver's Travels", Genre = "Science Fiction", PublishedDate =new DateTime(2022,3,18), AuthorId = 2 },
                new Book { Id =6, Title = "A Christmas Carol", Genre = "Historical", PublishedDate =new DateTime(2023,6,19), AuthorId = 2 },
                new Book { Id =7, Title = "White Fang", Genre = "Art", PublishedDate =new DateTime(2020,7,21), AuthorId = 3 },
                new Book { Id =8, Title = "A Christmas Carol", Genre = "Historical", PublishedDate =new DateTime(2023,1,6), AuthorId = 3 }
                );

            //Borrower Model
            modelBuilder.Entity<Borrower>().Property(bo => bo.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Borrower>().HasMany(b => b.Books).WithMany(bo => bo.Borrowers).UsingEntity(bb => bb.ToTable("BorrowedBooks"));
            modelBuilder.Entity<Borrower>().HasData(
                
                new Borrower { Id = 1 , Name = "Mohamed Saleh"},
                new Borrower { Id = 2 , Name = "Ahmed Salem"}

                );


        }


    }
}
