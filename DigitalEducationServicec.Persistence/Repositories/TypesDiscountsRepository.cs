using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TypesDiscountsRepository : GenericRepositoryAsync<TypesDiscountsTb>, ITypesDiscountsRepository
    {
        #region Fields
        private readonly DbSet<TypesDiscountsTb> _context;
        #endregion
        #region Constructors

        #endregion
        public TypesDiscountsRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TypesDiscountsTb>();
        }

        public async Task<List<TypesDiscountsTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }

}
