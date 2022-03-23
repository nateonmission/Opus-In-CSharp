using System;
using System.Collections.Generic;
using OpusInCSharp.Entities;
using System.Linq;
    

namespace OpusInCSharp.Repository
{
    public class InMemoryRepository : IItemsRepository
    {

        private readonly List<Book> books = new()
        {
            new Book
            {
                id = Guid.NewGuid(),
                title = "How to Learn Any Language",
                author = "Barry Farber",
                isbn = "1234567890",
                isbn13 = "1234567890123",
                publisher = "RandomHouse"
            },

            new Book
            {
                id = Guid.NewGuid(),
                title = "Harry Potter and the Philosopher's Stone",
                author = "J. K. Rowling",
                isbn = "2345678901",
                isbn13 = "2345678901231",
                publisher = "Bantham Books"
            },

            new Book
            {
                id = Guid.NewGuid(),
                title = "Ready Player One",
                author = "That Dude",
                isbn = "3456789012",
                isbn13 = "3456789012312",
                publisher = "Vanguard Books"
            },

        };

        public IEnumerable<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookByIsbn(string isbn)
        {
            return books.Where(book => book.isbn == isbn).SingleOrDefault();
        }

        public Book GetBookByIsbn13(string isbn13)
        {
            return books.Where(book => book.isbn13 == isbn13).SingleOrDefault();
        }

        public Book GetBookById(Guid id)
        {
            return books.Where(book => book.id == id).SingleOrDefault();
        }


        public Book CreateBook(Book book)
        {
            books.Add(book);
            return book;
        }

    }





}