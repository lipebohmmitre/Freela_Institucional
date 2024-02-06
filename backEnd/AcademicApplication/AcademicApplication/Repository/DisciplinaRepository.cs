using AcademicApplication.Data.Context;
using AcademicApplication.Data.Entities;
using AcademicApplication.Repository.RepositoryInterfaces;

namespace AcademicApplication.Repository
{
    public class DisciplinaRepository : CrudRepository<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
