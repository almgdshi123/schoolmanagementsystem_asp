using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class MonthRepository : GenericRepositoryAsync<MonthTb>, IMonthRepository
    {
        #region Fields
        private readonly DbSet<MonthTb> _context;
        #endregion
        #region Constructors
        public MonthRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<MonthTb>();
        }
        #endregion

        public async Task<List<MonthTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
