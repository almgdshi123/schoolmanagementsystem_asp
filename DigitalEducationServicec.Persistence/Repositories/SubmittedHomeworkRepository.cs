using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SubmittedHomeworkRepository : GenericRepositoryAsync<SubmittedHomeworkTb>, ISubmittedHomeworkRepository
    {
        #region Fields

        private readonly DbSet<SubmittedHomeworkTb> _context;
        #endregion
        #region Constructors
        public SubmittedHomeworkRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SubmittedHomeworkTb>();
        }
        #endregion

        public async Task<List<SubmittedHomeworkTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}


