using AcademicApplication.Data.Context;
using AcademicApplication.Repository;
using AcademicApplication.Services.ServicesInterfaces;

namespace AcademicApplication.Services
{
    public class CursoService : CursoRepository, ICursoService
    {
        public CursoService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
