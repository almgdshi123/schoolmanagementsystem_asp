using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TypesTuitionFeesRepository : GenericRepositoryAsync<TypesTuitionFeesTb>, ITypesTuitionFeesRepository
    {
        #region Fields
        private readonly DbSet<TypesTuitionFeesTb> _context;
        #endregion
        #region Constructors

        #endregion
        public TypesTuitionFeesRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TypesTuitionFeesTb>();
        }

        public async Task<List<TypesTuitionFeesTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }
}