using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StreetsRepository : GenericRepositoryAsync<StreetsTb>, IStreetsRepository
    {
        #region Fields
        private readonly DbSet<StreetsTb> _context;
        #endregion
        #region Constructors

        #endregion
        public StreetsRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StreetsTb>();
        }

        public async Task<List<StreetsTb>> GetListAsync()
        {

            return await _context.Include(x => x.DistributionOfBuseStreetTbs).ToListAsync();
        }


    }

}
