using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{

    public class GradesRepository : GenericRepositoryAsync<GradesTb>, IGradesRepository
    {
        #region Fields
        private readonly DbSet<GradesTb> _context;
        #endregion
        #region Constructors
        public GradesRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<GradesTb>();

        }
        #endregion


        public async Task<List<GradesTb>> GetListAsync()

        {
            return await _context.ToListAsync();
        }
    }

}
