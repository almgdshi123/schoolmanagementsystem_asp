using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class SemesterAcademicRepository : GenericRepositoryAsync<SemesterAcademicTb>, ISemesterAcademicRepository
    {
        #region Fields

        private readonly DbSet<SemesterAcademicTb> _context;
        #endregion
        #region Constructors
        public SemesterAcademicRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<SemesterAcademicTb>();
        }
        #endregion

        public async Task<List<SemesterAcademicTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }


    }
}
