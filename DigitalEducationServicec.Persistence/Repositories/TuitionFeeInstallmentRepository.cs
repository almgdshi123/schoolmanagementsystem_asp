using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TuitionFeeInstallmentRepository : GenericRepositoryAsync<TuitionFeeInstallmentTb>, ITuitionFeeInstallmentRepository
    {
        #region Fields
        private readonly DbSet<TuitionFeeInstallmentTb> _context;
        #endregion
        #region Constructors

        #endregion
        public TuitionFeeInstallmentRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TuitionFeeInstallmentTb>();
        }

        public async Task<List<TuitionFeeInstallmentTb>> GetListAsync()
        {

            return await _context.Include(x => x.ClassTuitionFees).ToListAsync();
        }


    }
}