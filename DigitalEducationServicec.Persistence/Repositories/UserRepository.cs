using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class UserRepository : GenericRepositoryAsync<UserDataTb>, IUserDataRepository
    {
        #region Fields

        private readonly DbSet<UserDataTb> _context;
        #endregion
        #region Constructors
        public UserRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<UserDataTb>();
        }
        #endregion

        public async Task<List<UserDataTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
