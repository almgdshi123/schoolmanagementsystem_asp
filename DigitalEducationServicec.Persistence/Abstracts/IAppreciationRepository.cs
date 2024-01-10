using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IAppreciationRepository : ICRUDRepository<AppreciationTb>
    {

        public Task<List<AppreciationTb>> GetListAsync();
    }

}

