using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class StudentParticipationBusRepository : GenericRepositoryAsync<StudentParticipationBusTb>, IStudentParticipationBusRepository
    {
        #region Fields
        private readonly DbSet<StudentParticipationBusTb> _context;
        #endregion
        #region Constructors

        #endregion
        public StudentParticipationBusRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<StudentParticipationBusTb>();
        }

        public async Task<List<StudentParticipationBusTb>> GetListAsync()
        {

            return await _context.Include(x => x.ParticipationType).Include(x => x.FileStudentId).ToListAsync();
        }


    }
}
