using Biblioteca.Application.Commands.LoanCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("/api/loans")]
    public class LoansController(IMediator mediator) : Controller
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] InsertLoanCommand command)
        {
            if (command is null)
                return BadRequest();

            var id = await mediator.Send(command);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, Se não Existir, retorna NotFound
            return NoContent();
        }
    }
}
