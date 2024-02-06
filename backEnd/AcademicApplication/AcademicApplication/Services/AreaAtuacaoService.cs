using AcademicApplication.Data.Context;
using AcademicApplication.Repository;
using AcademicApplication.Repository.RepositoryInterfaces;
using AcademicApplication.Services.ServicesInterfaces;

namespace AcademicApplication.Services
{
    public class AreaAtuacaoService : AreaAtuacaoRepository, IAreaAtuacaoService
    {
        public AreaAtuacaoService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
