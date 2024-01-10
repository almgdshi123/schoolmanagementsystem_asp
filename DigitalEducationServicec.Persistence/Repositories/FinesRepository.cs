using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class FinesRepository : GenericRepositoryAsync<FinesTb>, IFinesRepository
    {
        #region Fields
        private readonly DbSet<FinesTb> _context;
        #endregion
        #region Constructors

        #endregion
        public FinesRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<FinesTb>();
        }

        public async Task<List<FinesTb>> GetListAsync()
        {

            return await _context.Include(x => x.Year).ToListAsync();
        }


    }
}