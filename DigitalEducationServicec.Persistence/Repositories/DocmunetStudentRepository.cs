using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DocmunetStudentRepository : GenericRepositoryAsync<DocmunetStudentTb>, IDocmunetStudentRepository
    {
        #region Fields
        private readonly DbSet<DocmunetStudentTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DocmunetStudentRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DocmunetStudentTb>();
        }

        public async Task<List<DocmunetStudentTb>> GetListAsync()
        {

            return await _context.Include(x => x.FileStudent).ToListAsync();
        }


    }
}