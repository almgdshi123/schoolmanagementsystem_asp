using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class HomeworkRepository : GenericRepositoryAsync<HomeworkTb>, IHomeworkRepository
    {

        #region Fields
        private readonly DbSet<HomeworkTb> _context;
        #endregion
        #region Constructors
        public HomeworkRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<HomeworkTb>();
        }
        #endregion

        public async Task<List<HomeworkTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

    }
}
