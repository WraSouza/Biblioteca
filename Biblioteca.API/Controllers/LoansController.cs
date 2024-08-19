using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Biblioteca.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("/api/loans")]
    public class LoansController : Controller
    {
        private readonly ILoanService _loanService;
        private readonly IMediator _mediator;

        public LoansController(ILoanService loanService, IMediator mediator)
        {
            _loanService = loanService;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var loans = _loanService.GetAll();

            return Ok(loans);
        }       

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]       
        public IActionResult Post([FromBody] CreateLoanInputModel model)
        {
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
