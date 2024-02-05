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
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _service;
        private readonly IMapper _mapper;

        public CursoController(ICursoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<CursoDTO>> GetAllCursos()
        {
            var curso = await _service.GetAll();
            return _mapper.Map<List<CursoDTO>>(curso);

        }


        [HttpPost]
        public async Task<Curso> CreateCurso([FromBody] CursoDTO cursoDTO)
        {
            var curso = _mapper.Map<Curso>(cursoDTO);
            return await _service.CreatAsync(curso);
        }


        [HttpDelete("{id}")]
        public async Task<Curso> DeleteCurso(int id)
        {
            return await _service.DeleteAsync(id);
        }

    }
}
