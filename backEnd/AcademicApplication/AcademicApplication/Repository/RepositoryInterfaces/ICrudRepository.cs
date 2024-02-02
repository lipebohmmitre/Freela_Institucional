namespace AcademicApplication.Repository.RepositoryInterfaces
{
    public interface ICrudRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> CreatAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task<T> DeleteAsync(int id);
    }
}
