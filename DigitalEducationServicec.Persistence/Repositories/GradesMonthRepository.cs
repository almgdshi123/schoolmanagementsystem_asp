using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class GradesMonthRepository : GenericRepositoryAsync<GradesMonthTb>, IGradesMonthRepository
    {

        #region Fields
        private readonly DbSet<GradesMonthTb> _context;
        #endregion
        #region Constructors
        public GradesMonthRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<GradesMonthTb>();
        }
        #endregion

        public async Task<List<GradesMonthTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

    }
}
