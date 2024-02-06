using AcademicApplication.Data.Context;
using AcademicApplication.Repository.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace AcademicApplication.Repository
{
    public class CrudRepository<T> : ICrudRepository<T> where T : class
    {

        protected readonly ApplicationDbContext _context;

        public CrudRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> CreatAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(int id, T entity)
        {
            var entidadeBanco = await _context.Set<T>().FindAsync(id);
            _context.Entry(entidadeBanco).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            return entity;

        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
