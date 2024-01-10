using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SchoolRepository : GenericRepositoryAsync<SchoolTb>, ISchoolRepository
    {
        #region Fields

        private readonly DbSet<SchoolTb> _context;
        #endregion
        #region Constructors
        public SchoolRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SchoolTb>();
        }
        #endregion

        public async Task<List<SchoolTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
