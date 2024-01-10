using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class DocmunetsRepository : GenericRepositoryAsync<DocmunetsTb>, IDocmunetsRepository
    {
        #region Fields
        private readonly DbSet<DocmunetsTb> _context;
        #endregion
        #region Constructors

        #endregion
        public DocmunetsRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<DocmunetsTb>();
        }

        public async Task<List<DocmunetsTb>> GetListAsync()
        {

            return await _context.Include(x => x.DocmunetsClassTbs).ToListAsync();
        }


    }
}
