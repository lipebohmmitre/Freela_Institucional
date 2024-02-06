using AcademicApplication.Data.Entities;
using AcademicApplication.Services.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _service;

        public DisciplinaController(IDisciplinaService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IEnumerable<Disciplina>> GetAll()
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public async Task<Disciplina> CreateDisciplina([FromBody] Disciplina disciplina)
        {
            return await _service.CreatAsync(disciplina);
        }

    }
}
