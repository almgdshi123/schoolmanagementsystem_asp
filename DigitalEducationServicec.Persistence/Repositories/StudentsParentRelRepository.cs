using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StudentsParentRelRepository : GenericRepositoryAsync<StudentsParentRelTb>, IStudentsParentRelRepository
    {
        #region Fields

        private readonly DbSet<StudentsParentRelTb> _context;
        #endregion
        #region Constructors
        public StudentsParentRelRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StudentsParentRelTb>();
        }
        #endregion

        public async Task<List<StudentsParentRelTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
