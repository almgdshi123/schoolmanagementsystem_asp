using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class VacationsRepository : GenericRepositoryAsync<VacationsTb>, IVacationsRepository
    {
        #region Fields
        private readonly DbSet<VacationsTb> _context;
        #endregion
        #region Constructors

        #endregion
        public VacationsRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<VacationsTb>();
        }

        public async Task<List<VacationsTb>> GetListAsync()
        {

            return await _context.Include(x => x.Year).ToListAsync();
        }


    }
}