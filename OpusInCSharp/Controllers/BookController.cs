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
            var books = repository.GetBooks().Select( book => book.asDTO() );
            return books;
        }

        // GET /books/{isbn}
        [HttpGet("isbn/{isbn}")]
        public ActionResult<BookDto> GetBookByIsbn(string isbn)
        {
            var book = repository.GetBookByIsbn(isbn);

            if(book is null){
                return NotFound();
            }

            return book.asDTO();
        }

        // GET /books/{isbn13}
        [HttpGet("isbn13/{isbn13}")]
        public ActionResult<BookDto> GetBookByIsbn13(string isbn13)
        {
            var book = repository.GetBookByIsbn13(isbn13);

            if(book is null){
                return NotFound();
            }

            return book.asDTO();
        }

        // GET /books/{id}
        [HttpGet("id/{id}")]
        public ActionResult<BookDto> GetBookById(Guid id)
        {
            var book = repository.GetBookById(id);

            if(book is null){
                return NotFound();
            }

            return book.asDTO();
        }

        // POST /book 
        [HttpPost]
        public ActionResult<BookDto> CreateBook(CreateBookDto bookDto)
        {
            Book book = new(){
                id = Guid.NewGuid(),
                title = bookDto.title,
                author = bookDto.author,
                isbn = bookDto.isbn,
                isbn13 = bookDto.isbn13       
            };

            repository.CreateBook(book);

            if(bookDto is null){
                return NotFound();
            }

            return CreatedAtAction(nameof(GetBookById), new {id = book.id}, book.asDTO() );
        }





    }

















}