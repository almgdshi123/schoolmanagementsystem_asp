using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IDistributionOfBuseStreetRepository : ICRUDRepository<DistributionOfBuseStreetTb>
    {

        public Task<List<DistributionOfBuseStreetTb>> GetListAsync();
    }

}

