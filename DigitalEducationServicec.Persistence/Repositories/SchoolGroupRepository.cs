using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SchoolGroupRepository : GenericRepositoryAsync<SchoolGroupTb>, ISchoolGroupRepository
    {
        #region Fields

        private readonly DbSet<SchoolGroupTb> _context;
        #endregion
        #region Constructors
        public SchoolGroupRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SchoolGroupTb>();
        }
        #endregion

        public async Task<List<SchoolGroupTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
