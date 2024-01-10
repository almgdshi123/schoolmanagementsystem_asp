using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class YearDataRepository : GenericRepositoryAsync<YearDataTb>, IYearDataRepository
    {
        #region Fields

        private readonly DbSet<YearDataTb> _context;
        #endregion
        #region Constructors
        public YearDataRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<YearDataTb>();
        }
        #endregion

        public async Task<List<YearDataTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
