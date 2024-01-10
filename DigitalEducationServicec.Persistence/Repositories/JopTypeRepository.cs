using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class JopTypeRepository : GenericRepositoryAsync<JopTypeTb>, IJopTypeRepository
    {
        #region Fields
        private readonly DbSet<JopTypeTb> _context;
        #endregion
        #region Constructors

        #endregion
        public JopTypeRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<JopTypeTb>();
        }

        public async Task<List<JopTypeTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }

}
