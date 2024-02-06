using AcademicApplication.Data.Context;
using AcademicApplication.Data.Entities;
using AcademicApplication.Repository.RepositoryInterfaces;

namespace AcademicApplication.Repository
{
    public class MatriculaRepository : CrudRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
