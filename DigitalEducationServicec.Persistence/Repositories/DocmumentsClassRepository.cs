using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DocmumentsClassRepository : GenericRepositoryAsync<DocmunetsClassTb>, IDocmunetsClassRepository
    {
        #region Fields
        private readonly DbSet<DocmunetsClassTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DocmumentsClassRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DocmunetsClassTb>();
        }

        public async Task<List<DocmunetsClassTb>> GetListAsync()
        {

            return await _context.Include(x => x.DocmunetStudentTbs).ToListAsync();
        }


    }
}