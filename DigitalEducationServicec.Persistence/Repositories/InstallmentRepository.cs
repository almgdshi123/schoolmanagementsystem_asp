using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class InstallmentRepository : GenericRepositoryAsync<InstallmentTb>, IInstallmentRepository
    {
        #region Fields
        private readonly DbSet<InstallmentTb> _context;
        #endregion
        #region Constructors

        #endregion
        public InstallmentRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<InstallmentTb>();
        }

        public async Task<List<InstallmentTb>> GetListAsync()
        {
            return await _context.Include(x => x.TuitionFeeInstallment).ToListAsync();
        }


    }
}
