using DigitalEducationServicec.Domain.Entity;

using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class FileStudentRepository : GenericRepositoryAsync<FileStudentTb>, IFileStudentRepository
    {
        #region Fields
        private readonly DbSet<FileStudentTb> _context;
        #endregion
        #region Constructors
        public FileStudentRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<FileStudentTb>();
        }
        #endregion

        public async Task<List<FileStudentTb>> GetListAsync()
        {
            return await _context.ToListAsync();
        }


    }

}
