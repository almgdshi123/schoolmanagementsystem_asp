using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SectionDataRepository : GenericRepositoryAsync<SectionDataTb>, ISectionDataRepository
    {
        #region Fields

        private readonly DbSet<SectionDataTb> _context;
        #endregion
        #region Constructors
        public SectionDataRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SectionDataTb>();
        }
        #endregion

        public async Task<List<SectionDataTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
