using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SpecializationRepository : GenericRepositoryAsync<SpecializationTb>, ISpecializationRepository
    {
        #region Fields

        private readonly DbSet<SpecializationTb> _context;
        #endregion
        #region Constructors
        public SpecializationRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SpecializationTb>();
        }
        #endregion

        public async Task<List<SpecializationTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

    }

}
