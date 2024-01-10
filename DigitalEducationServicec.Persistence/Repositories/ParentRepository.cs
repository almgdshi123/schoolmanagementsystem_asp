using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class ParentRepository : GenericRepositoryAsync<ParentTb>, IParentRepository
    {
        #region Fields
        private readonly DbSet<ParentTb> _parents;
        #endregion
        #region Constructors
        public ParentRepository(DigitalEducationServiceDbnContext context) : base(context) {

            _parents = context.Set<ParentTb>();
        }
        #endregion

        public async Task<List<ParentTb>> GetParentListAsync()
        {
            return await _parents.ToListAsync();

        }

     

    }
}
