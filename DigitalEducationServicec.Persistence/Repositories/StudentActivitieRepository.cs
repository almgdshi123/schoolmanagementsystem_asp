using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StudentActivitieRepository : GenericRepositoryAsync<StudentActivitieTb>, IStudentActivitieRepository
    {
        #region Fields
        private readonly DbSet<StudentActivitieTb> _context;
        #endregion
        #region Constructors

        #endregion
        public StudentActivitieRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StudentActivitieTb>();
        }

        public async Task<List<StudentActivitieTb>> GetListAsync()
        {

            return await _context.Include(x => x.Teacher).Include(x => x.TypeOfActivitie).ToListAsync();
        }

    }
}
