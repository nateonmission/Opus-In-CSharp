using OpusInCSharp.Dtos;
using OpusInCSharp.Entities;

namespace OpusInCSharp
{
    public static class Extensions
    {
        public static BookDto asDTO(this Book book)
        {
            return new BookDto{
                id = book.id,
                title = book.title,
                author = book.author,
                publisher = book.publisher,
                isbn = book.isbn,
                isbn13 = book.isbn13,
                description = book.description
            };
        }
    }


}