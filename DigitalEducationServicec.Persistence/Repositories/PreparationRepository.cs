using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class PreparationRepository : GenericRepositoryAsync<PreparationTb>, IPreparationRepository
    {
        #region Fields

        private readonly DbSet<PreparationTb> _context;
        #endregion
        #region Constructors
        public PreparationRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<PreparationTb>();
        }
        #endregion

        public async Task<List<PreparationTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }

}
