using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TypeOfActivitiesRepository : GenericRepositoryAsync<TypeOfActivitiesTb>, ITypeOfActivitiesRepository
    {
        #region Fields
        private readonly DbSet<TypeOfActivitiesTb> _context;
        #endregion
        #region Constructors

        #endregion
        public TypeOfActivitiesRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TypeOfActivitiesTb>();
        }

        public async Task<List<TypeOfActivitiesTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }
}
