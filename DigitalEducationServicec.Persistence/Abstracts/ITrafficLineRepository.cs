using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ITrafficLineRepository : ICRUDRepository<TrafficLineTb>
    {

        public Task<List<TrafficLineTb>> GetListAsync();
    }

}