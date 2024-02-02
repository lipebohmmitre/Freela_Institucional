using AcademicApplication.Data.Context;
using AcademicApplication.Data.Entities;
using AcademicApplication.Repository.RepositoryInterfaces;

namespace AcademicApplication.Repository
{
    public class CategoriaRepository : CrudRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
