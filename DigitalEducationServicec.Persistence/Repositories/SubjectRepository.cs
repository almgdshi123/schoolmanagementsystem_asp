using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<SubjectTb>, ISubjectRepository
    {

        #region Fields

        private readonly DbSet<SubjectTb> _context;
        #endregion
        #region Constructors
        public SubjectRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SubjectTb>();
        }
        #endregion

        public async Task<List<SubjectTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
