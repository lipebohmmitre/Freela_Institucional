using AcademicApplication.Data.Context;
using AcademicApplication.Repository;
using AcademicApplication.Services.ServicesInterfaces;

namespace AcademicApplication.Services
{
    public class DisciplinaService : DisciplinaRepository, IDisciplinaService
    {
        public DisciplinaService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
