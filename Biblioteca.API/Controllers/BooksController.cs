using Biblioteca.Application.Commands.BookCommands;
using Biblioteca.Application.Queries.GetAllBooks;
using Biblioteca.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IMediator _mediator;

        public BooksController(IBookService bookService, IMediator mediator)
        {
            _bookService = bookService;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getAllBooks = new GetAllBooksQuery();

            var books = await _mediator.Send(getAllBooks);            

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertBookCommand command)
        {
            if (command is null)
                return BadRequest();
            
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, Se não Existir, retorna NotFound
            return NoContent();
        }

    }
}
