using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class ClassDataRepository : GenericRepositoryAsync<ClassDataTb>, IClassDataRepository
    {
        #region Fields
        private readonly DbSet<ClassDataTb> _context;
        #endregion
        #region Constructors

        #endregion
        public ClassDataRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<ClassDataTb>();
        }

        public async Task<List<ClassDataTb>> GetListAsync()
        {

            return await _context.Include(x => x.Stage).ToListAsync();
        }


    }
}
