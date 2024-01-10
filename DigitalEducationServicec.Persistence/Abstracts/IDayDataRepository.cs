using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IDayDataRepository : ICRUDRepository<DayDataTb>
    {

        public Task<List<DayDataTb>> GetListAsync();
    }

}

