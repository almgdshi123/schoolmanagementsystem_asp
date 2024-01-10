using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class AcademicDiscountRepository : GenericRepositoryAsync<AcademicDiscountTb>, IAcademicDiscountRepository
    {
        #region Fields
        private readonly DbSet<AcademicDiscountTb> _context;
        #endregion
        #region Constructors

        #endregion
        public AcademicDiscountRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<AcademicDiscountTb>();
        }

        public async Task<List<AcademicDiscountTb>> GetListAsync()
        {

            return await _context.Include(x => x.TypesDiscount).ToListAsync();
        }


    }
}


