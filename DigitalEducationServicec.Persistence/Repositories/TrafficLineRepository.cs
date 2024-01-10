using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class TrafficLineRepository : GenericRepositoryAsync<TrafficLineTb>, ITrafficLineRepository
    {
        #region Fields
        private readonly DbSet<TrafficLineTb> _context;
        #endregion
        #region Constructors

        #endregion
        public TrafficLineRepository(DigitalEducationServiceDbnContext context) : base(context)
        {
            _context = context.Set<TrafficLineTb>();
        }

        public async Task<List<TrafficLineTb>> GetListAsync()
        {

            return await _context.ToListAsync();
        }


    }
}
