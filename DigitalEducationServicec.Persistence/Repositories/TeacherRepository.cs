using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TeacherRepository : GenericRepositoryAsync<TeacherTb>, ITeacherRepository
    {
        #region Fields

        private readonly DbSet<TeacherTb> _context;
        #endregion
        #region Constructors
        public TeacherRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TeacherTb>();
        }
        #endregion

        public async Task<List<TeacherTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
