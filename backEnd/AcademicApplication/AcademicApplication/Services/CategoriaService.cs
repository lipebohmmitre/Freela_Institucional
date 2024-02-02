using AcademicApplication.Data.Context;
using AcademicApplication.Repository;
using AcademicApplication.Services.ServicesInterfaces;

namespace AcademicApplication.Services
{
    public class CategoriaService : CategoriaRepository, ICategoriaService
    {
        public CategoriaService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
