using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SectionCodeRepository : GenericRepositoryAsync<SectionCodeTb>, ISectionCodeRepository
    {
        #region Fields
        private readonly DbSet<SectionCodeTb> _context;
        #endregion
        #region Constructors

        #endregion
        public SectionCodeRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SectionCodeTb>();
        }

        public async Task<List<SectionCodeTb>> GetListAsync()
        {

            return await _context.Include(x => x.SectionDataTbs).ToListAsync();
        }


    }
}
