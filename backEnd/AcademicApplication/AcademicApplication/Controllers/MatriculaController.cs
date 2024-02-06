using AcademicApplication.Data.Entities;
using AcademicApplication.Services.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService _service;

        public MatriculaController(IMatriculaService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IEnumerable<Matricula>> GetAll()
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public async Task<Matricula> CreateMatricula([FromBody] Matricula matricula)
        {
            return await _service.CreatAsync(matricula);
        }

    }
}
