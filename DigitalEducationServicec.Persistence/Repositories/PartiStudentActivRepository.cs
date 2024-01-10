using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class PartiStudentActivRepository : GenericRepositoryAsync<ParticiStudentActivTb>, IParticiStudentActivRepository
    {
        #region Fields
        private readonly DbSet<ParticiStudentActivTb> _context;
        #endregion
        #region Constructors

        #endregion
        public PartiStudentActivRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<ParticiStudentActivTb>();
        }

        public async Task<List<ParticiStudentActivTb>> GetListAsync()
        {

            return await _context.Include(x => x.FileStudent).Include(x => x.StudentActivitie).ToListAsync();
        }


    }
}