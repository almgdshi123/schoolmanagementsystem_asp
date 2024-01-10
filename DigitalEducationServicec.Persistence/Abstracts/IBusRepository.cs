using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IBusRepository : ICRUDRepository<BusTb>
    {

        public Task<List<BusTb>> GetListAsync();
    }

}

