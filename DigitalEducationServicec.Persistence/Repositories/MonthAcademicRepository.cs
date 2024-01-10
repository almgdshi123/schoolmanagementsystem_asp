using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class MonthAcademicRepository : GenericRepositoryAsync<MonthAcademicTb>, IMonthAcademicRepository
    {
        #region Fields
        private readonly DbSet<MonthAcademicTb> _context;
        #endregion
        #region Constructors
        public MonthAcademicRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<MonthAcademicTb>();
        }
        #endregion

        public async Task<List<MonthAcademicTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
