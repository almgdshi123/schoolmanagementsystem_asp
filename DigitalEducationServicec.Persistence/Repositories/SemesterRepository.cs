using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SemesterRepository : GenericRepositoryAsync<SemesterTb>, ISemesterRepository
    {
        #region Fields

        private readonly DbSet<SemesterTb> _context;
        #endregion
        #region Constructors
        public SemesterRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SemesterTb>();
        }
        #endregion

        public async Task<List<SemesterTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }



    }
}
