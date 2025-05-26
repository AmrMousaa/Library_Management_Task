using Library_Management_System.Models;
using System.Collections.Generic;

namespace Library_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var _context = new ApplicationDbContext();


            /* //List all books with their authors' names.
             var Books = from b in _context.Books
                         join a in _context.Authors
                         on b.AuthorId equals a.Id
                         select new { BookName = b.Title , AuthorName = a.Name };

             foreach (var book in Books)
             {
                 Console.WriteLine($"AuthorName: {book.AuthorName} - BookName: {book.BookName}");
             }*/

            /* // Find books in a specific genre.

             var booksGenre = _context.Books.Where(b => b.Genre == "Art");

             foreach (var book in booksGenre)
             {
                 Console.WriteLine(book.Title);
             }*/

            /* // Count the number of books borrowed by a specific borrower.

             var borrowedBookCount = _context.Borrowers
                 .Where(b => b.Id == 1)
                 .SelectMany( a=> a.Books)
                 .Count();

             Console.WriteLine(borrowedBookCount);
            */

            // List borrowers and the books they have borrowed.
            var result = from borrower in _context.Borrowers
                         join Book in _context.Books
                         on borrower.Id equals Book.Borrowers
                             .Select(b => b.Id).FirstOrDefault()
                         select new
                         {
                             BorrowerName = borrower.Name,
                             BookTitle = Book.Title
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"Borrower: {item.BorrowerName}");
            }

        }
    }
}
