

using Microsoft.EntityFrameworkCore.Storage;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ICRUDRepository<T> where T : class
    {
        Task DeleteRangeAsync(ICollection<T> entities);
        Task<T> GetByIdAsync(long id);
        Task<List<T>> GetAllListAsyN();

        Task SaveChangesAsync();
        void Commit();
        void RollBack();
        IQueryable<T> GetTableNoTracking();
        IDbContextTransaction BeginTransaction();
        IQueryable<T> GetTableAsTracking();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(ICollection<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(ICollection<T> entities);
        Task DeleteAsync(T entity);
    }
}
