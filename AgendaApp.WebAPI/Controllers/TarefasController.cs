using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Cadastro de tarefa");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("ATUALIZAR");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETAR");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Consultar");
        }
    }
}
