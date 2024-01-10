using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<StudentTb>, IStudentRepository
    {
        #region Fields

        private readonly DbSet<StudentTb> _context;
        #endregion
        #region Constructors
        public StudentRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StudentTb>();
        }
        #endregion

        public async Task<List<StudentTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }
    }
}
