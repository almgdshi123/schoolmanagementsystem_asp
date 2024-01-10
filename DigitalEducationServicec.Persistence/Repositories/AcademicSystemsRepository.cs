using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class AcademicSystemsRepository : GenericRepositoryAsync<AcademicSystemsTb>, IAcademicSystemsRepository
    {
        #region Fields
        private readonly DbSet<AcademicSystemsTb> _context;
        #endregion
        #region Constructors
        public AcademicSystemsRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<AcademicSystemsTb>();
        }
        #endregion

        public async Task<List<AcademicSystemsTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }

        
    }

    }
