using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class QualificationRepository : GenericRepositoryAsync<QualificationTb>, IQualificationRepository
    {
        #region Fields

        private readonly DbSet<QualificationTb> _context;
        #endregion
        #region Constructors
        public QualificationRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<QualificationTb>();
        }
        #endregion

        public async Task<List<QualificationTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }

}
