using Biblioteca.Application.Commands.BookCommands;
using Biblioteca.Application.Queries.GetAllBooks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("api/books")]
    public class BooksController(IMediator mediator) : Controller
    {
       
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var getAllBooks = new GetAllBooksQuery();

            var books = await mediator.Send(getAllBooks);            

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {          

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] InsertBookCommand command)
        {
            if (command is null)
                return BadRequest();
            
            var id = await mediator.Send(command);

            if(id == 0)
                return BadRequest("Livro Já Existe no Cadastro");

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
