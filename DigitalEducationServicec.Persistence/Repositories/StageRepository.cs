using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StageRepository : GenericRepositoryAsync<StageTb>, IStageRepository
    {
        #region Fields

        private readonly DbSet<StageTb> _context;
        #endregion
        #region Constructors
        public StageRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StageTb>();
        }
        #endregion

        public async Task<List<StageTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

    }
}
