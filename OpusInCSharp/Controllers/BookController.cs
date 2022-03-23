using Microsoft.AspNetCore.Mvc;
using OpusInCSharp.Repository;
using OpusInCSharp.Entities;
using System.Collections.Generic;
using System;
using OpusInCSharp.Dtos;
using System.Linq;

namespace OpusInCSharp.Controllers
{
    [ApiController]
    [Route("books")]
    public class BookController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public BookController(IItemsRepository repository){
            this.repository = repository;
        }

        // GET /books
        [HttpGet]
        public IEnumerable<BookDto> GetBooks()
        {
            var books = repository.GetBooks().Select( book => new BookDto{
                id = book.id,
                title = book.title,
                author = book.author,
                publisher = book.publisher,
                isbn = book.isbn,
                isbn13 = book.isbn13,
                description = book.description
            });
            return books;
        }

        // GET /books/{isbn}
        [HttpGet("isbn/{isbn}")]
        public ActionResult<Book> GetBookByIsbn(string isbn)
        {
            var book = repository.GetBookByIsbn(isbn);

            if(book is null){
                return NotFound();
            }

            return book;
        }

        // GET /books/{isbn13}
        [HttpGet("isbn13/{isbn13}")]
        public ActionResult<Book> GetBookByIsbn13(string isbn13)
        {
            var book = repository.GetBookByIsbn13(isbn13);

            if(book is null){
                return NotFound();
            }

            return book;
        }

        // GET /books/{id}
        [HttpGet("id/{id}")]
        public ActionResult<Book> GetBookById(Guid id)
        {
            var book = repository.GetBookById(id);

            if(book is null){
                return NotFound();
            }

            return book;
        }



    }

















}