using AcademicApplication.Data.Context;
using AcademicApplication.Repository;
using AcademicApplication.Services.ServicesInterfaces;

namespace AcademicApplication.Services
{
    public class MatriculaService : MatriculaRepository, IMatriculaService
    {
        public MatriculaService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
