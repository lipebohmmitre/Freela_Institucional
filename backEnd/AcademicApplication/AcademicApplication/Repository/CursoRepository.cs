using AcademicApplication.Data.Context;
using AcademicApplication.Data.Entities;
using AcademicApplication.Repository.RepositoryInterfaces;

namespace AcademicApplication.Repository
{
    public class CursoRepository : CrudRepository<Curso>, ICursoRepository
    {
        public CursoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
