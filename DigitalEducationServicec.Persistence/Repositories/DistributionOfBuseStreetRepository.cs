using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DistributionOfBuseStreetRepository : GenericRepositoryAsync<DistributionOfBuseStreetTb>, IDistributionOfBuseStreetRepository
    {
        #region Fields
        private readonly DbSet<DistributionOfBuseStreetTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DistributionOfBuseStreetRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DistributionOfBuseStreetTb>();
        }

        public async Task<List<DistributionOfBuseStreetTb>> GetListAsync()
        {

            return await _context.Include(x => x.Street).ToListAsync();
        }


    }
}