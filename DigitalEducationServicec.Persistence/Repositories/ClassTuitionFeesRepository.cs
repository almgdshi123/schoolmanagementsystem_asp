using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class ClassTuitionFeesRepository : GenericRepositoryAsync<ClassTuitionFeesTb>, IClassTuitionFeesRepository
    {
        #region Fields
        private readonly DbSet<ClassTuitionFeesTb> _context;
        #endregion
        #region Constructors

        #endregion
        public ClassTuitionFeesRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<ClassTuitionFeesTb>();
        }

        public async Task<List<ClassTuitionFeesTb>> GetListAsync()
        {

            return await _context.Include(x => x.TuitionFeeInstallmentTbs).ToListAsync();
        }


    }
}