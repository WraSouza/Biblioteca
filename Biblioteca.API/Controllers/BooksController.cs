using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("api/books")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookService.GetAll();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookService.GetById(id);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] InsertBookInputModel insertBookModel)
        {
            if (insertBookModel is null)
                return BadRequest();

            var id = _bookService.Create(insertBookModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, insertBookModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, Se não Existir, retorna NotFound
            return NoContent();
        }

    }
}
