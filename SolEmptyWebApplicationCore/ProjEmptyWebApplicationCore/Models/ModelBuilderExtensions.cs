using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mary",
                    Department = Dept.IT,
                    Email = "mary@yahoo.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.HR,
                    Email = "john@yahoo.com"
                }
                );
        }

        public static void SeedPubliser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    Id = 1,
                    Nombre = "Publi 1"
                },
                new Publisher
                {
                    Id = 2,
                    Nombre = "Publi 2"
                },
                new Publisher
                {
                    Id = 3,
                    Nombre = "Publi 3"
                },
                new Publisher
                {
                    Id = 4,
                    Nombre = "Publi 4"
                }
                );
        }

        public static void SeedBook(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Title 1",
                    Description = "Desc 1",
                    IsRead = false,
                    DataRead = null,
                    Rate = 1,
                    Genre = "Fiction",
                    Author = "Author 1",
                    CoverUrl = "Url 1",
                    DateAdded = DateTime.UtcNow,
                    PublisherId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Title 2",
                    Description = "Desc 2",
                    IsRead = false,
                    DataRead = null,
                    Rate = 1,
                    Genre = "Fiction",
                    Author = "Author 2",
                    CoverUrl = "Url 2",
                    DateAdded = DateTime.UtcNow,
                    PublisherId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Title 3",
                    Description = "Desc 3",
                    IsRead = false,
                    DataRead = null,
                    Rate = 1,
                    Genre = "Fiction",
                    Author = "Author 3",
                    CoverUrl = "Url 3",
                    DateAdded = DateTime.UtcNow,
                    PublisherId = 1
                },
                new Book
                {
                    Id = 4,
                    Title = "Title 4",
                    Description = "Desc 4",
                    IsRead = false,
                    DataRead = null,
                    Rate = 1,
                    Genre = "Fiction",
                    Author = "Author 4",
                    CoverUrl = "Url 4",
                    DateAdded = DateTime.UtcNow,
                    PublisherId = 4
                }
                );
        }

        public static void SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FullName = "Author 1"
                },
                new Author
                {
                    Id = 2,
                    FullName = "Author 2"
                },
                new Author
                {
                    Id = 3,
                    FullName = "Author 3"
                }
                );
        }

        public static void SeedBook_Author(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>().HasData(
                new Book_Author
                {
                    Id = 1,
                    BookId = 1,
                    AuthorId = 1
                },
                new Book_Author
                {
                    Id = 2,
                    BookId = 2,
                    AuthorId = 2
                },
                new Book_Author
                {
                    Id = 3,
                    BookId = 2,
                    AuthorId = 3
                },
                new Book_Author
                {
                    Id = 4,
                    BookId = 3,
                    AuthorId = 1
                },
                new Book_Author
                {
                    Id = 5,
                    BookId = 3,
                    AuthorId = 2
                },
                new Book_Author
                {
                    Id = 6,
                    BookId = 3,
                    AuthorId = 3
                }
                );
        }
    }
}
