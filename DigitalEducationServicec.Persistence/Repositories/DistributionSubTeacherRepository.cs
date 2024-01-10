using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DistributionSubTeacherRepository : GenericRepositoryAsync<DistributionSubTeacherTb>, IDistributionSubTeacherRepository
    {
        #region Fields
        private readonly DbSet<DistributionSubTeacherTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DistributionSubTeacherRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DistributionSubTeacherTb>();
        }

        public async Task<List<DistributionSubTeacherTb>> GetListAsync()
        {

            return await _context.Include(x => x.Teacher).Include(x => x.GradesSemesterTbs).ToListAsync();
        }


    }
}