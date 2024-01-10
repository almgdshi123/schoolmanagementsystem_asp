using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class BusRepository : GenericRepositoryAsync<BusTb>, IBusRepository
    {
        #region Fields
        private readonly DbSet<BusTb> _context;
        #endregion
        #region Constructors

        #endregion
        public BusRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<BusTb>();
        }

        public async Task<List<BusTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }
}

