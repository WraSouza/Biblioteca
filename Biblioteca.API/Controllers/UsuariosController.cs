using Biblioteca.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.API.Controllers
{
    [Route("/api/usuarios")]
    public class UsuariosController : Controller
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
        public IActionResult Post([FromBody] CreateUserInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, Se não Existir, retorna NotFound
            return NoContent();
        }

    }
}
