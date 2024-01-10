using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{

    public class AcademicStatusesRepository : GenericRepositoryAsync<AcademicStatusesTb>, IAAcademicStatusRepository
    {
        #region Fields
        private readonly DbSet<AcademicStatusesTb> _context;
        #endregion
        #region Constructors
        public AcademicStatusesRepository(DigitalEducationServiceDbnContext context) : base(context) {
            _context = context.Set<AcademicStatusesTb>();
        }
        #endregion

        public async Task<List<AcademicStatusesTb>> GetAcademicStatusListAsync()
        {
            return await _context.ToListAsync();
        }
    }

}
