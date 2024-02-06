using AcademicApplication.Data.Context;
using AcademicApplication.Data.Entities;
using AcademicApplication.Repository.RepositoryInterfaces;

namespace AcademicApplication.Repository
{
    public class AreaAtuacaoRepository : CrudRepository<AreaAtuacao>, IAreaAtuacaoRepository
    {
        public AreaAtuacaoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
