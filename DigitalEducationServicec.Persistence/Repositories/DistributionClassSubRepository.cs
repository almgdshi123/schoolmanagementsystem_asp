using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DistributionClassSubRepository : GenericRepositoryAsync<DistributionClassSubTb>, IDistributionClassSubRepository
    {
        #region Fields
        private readonly DbSet<DistributionClassSubTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DistributionClassSubRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DistributionClassSubTb>();
        }

        public async Task<List<DistributionClassSubTb>> GetListAsync()
        {

            return await _context.Include(x => x.ClassCode).ToListAsync();
        }


    }
}