using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IStreetsRepository : ICRUDRepository<StreetsTb>
    {

        public Task<List<StreetsTb>> GetListAsync();
    }

}