using Biblioteca.Application.InputModels;
using Biblioteca.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("/api/loans")]
    public class LoansController : Controller
    {
        private readonly ILoanService _loanService;
        public LoansController(ILoanService loanService)
        {
            _loanService = loanService;
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
