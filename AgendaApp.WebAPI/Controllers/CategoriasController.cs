using AgendaApp.Data.Repositories;
using AgendaApp.WebAPI.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CategoriasController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categoriaRepository = new CategoriaRepository();

            var result = _mapper.Map<List<CategoriaResponseDto>>(categoriaRepository.GetAll());

         
            return Ok(result);
        }
    }
}
