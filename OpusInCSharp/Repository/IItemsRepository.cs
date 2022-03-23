using System;
using System.Collections.Generic;
using OpusInCSharp.Entities;

namespace OpusInCSharp.Repository
{
    public interface IItemsRepository 
    {
        Book GetBookByIsbn(string isbn);
        Book GetBookByIsbn13(string isbn13);
        Book GetBookById(Guid id);
        IEnumerable<Book> GetBooks();

        Book CreateBook(Book book);
    }


}