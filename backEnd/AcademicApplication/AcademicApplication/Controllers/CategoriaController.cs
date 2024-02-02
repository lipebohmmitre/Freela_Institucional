using AcademicApplication.Data.Entities;
using AcademicApplication.DTOs;
using AcademicApplication.Services.ServicesInterfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaService _service;
        private readonly IMapper _mapper;


        public CategoriaController(ICategoriaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }





        [HttpGet]
        public async Task<IEnumerable<CategoriaDTO>> GetAllCategories()
        {
            var categoriaList = await _service.GetAll();
            var categoriaDto = _mapper.Map<List<CategoriaDTO>>(categoriaList);
            return categoriaDto;
        }

        [HttpGet("{id}")]
        public async Task<CategoriaDTO> GetById(int id)
        {
            var categoria = await _service.GetById(id);
            return _mapper.Map<CategoriaDTO>(categoria);
        }


        [HttpPost]
        public async Task<Categoria> PostCategoria([FromBody] CategoriaDTO categoriaDto)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDto);
            await _service.CreatAsync(categoria);

            return categoria;
        }

        [HttpPut]
        public async Task<Categoria> PutCategoria([FromBody] CategoriaDTO categoriaDto)
        {
            var cat = _mapper.Map<Categoria>(categoriaDto);
            await _service.UpdateAsync(categoriaDto.CategoriaId, cat);
            return cat;
        }

        [HttpDelete("{id}")]
        public async Task<Categoria> DeleteCategoria(int id)
        {
            var categoria = await _service.DeleteAsync(id);
            return categoria;
        } 
    }
}
