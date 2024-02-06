using AcademicApplication.Data.Entities;
using AcademicApplication.Services.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcademicApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaAtuacaoController : ControllerBase
    {
        private readonly IAreaAtuacaoService _service;


        public AreaAtuacaoController(IAreaAtuacaoService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IEnumerable<AreaAtuacao>> GetAll()
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public async Task<AreaAtuacao> CreateAreaAtuacao([FromBody] AreaAtuacao areaAtuacao)
        {
            return await _service.CreatAsync(areaAtuacao);
        }
    }
}
