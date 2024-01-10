using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class GradesSemesterRepository : GenericRepositoryAsync<GradesSemesterTb>, IGradesSemesterRepository
    {
        #region Fields
        private readonly DbSet<GradesSemesterTb> _context;
        #endregion
        #region Constructors
        public GradesSemesterRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<GradesSemesterTb>();
        }
        #endregion

        public async Task<List<GradesSemesterTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

    }
}
