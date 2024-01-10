using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class AppreciationRepository : GenericRepositoryAsync<AppreciationTb>, IAppreciationRepository
    {
        #region Fields
        private readonly DbSet<AppreciationTb> _context;
        #endregion
        #region Constructors

        #endregion
        public AppreciationRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<AppreciationTb>();
        }

        public async Task<List<AppreciationTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }
    }

}