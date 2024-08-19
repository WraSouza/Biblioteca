using Biblioteca.Application.Commands.UserCommands;
using Biblioteca.Application.Queries.GetAllBooks;
using Biblioteca.Application.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("/api/usuarios")]
    public class UsuariosController : Controller
    {
        private readonly IMediator _mediator;
        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getAllUsers = new GetAllUsersQuery();

            var allUsers = await _mediator.Send(getAllUsers);

            return Ok(allUsers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertUserCommand command)
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
