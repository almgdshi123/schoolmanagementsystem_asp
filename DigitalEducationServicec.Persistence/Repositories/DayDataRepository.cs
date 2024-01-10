using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DayDataRepository : GenericRepositoryAsync<DayDataTb>, IDayDataRepository
    {
        #region Fields
        private readonly DbSet<DayDataTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DayDataRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DayDataTb>();
        }

        public async Task<List<DayDataTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }
}
