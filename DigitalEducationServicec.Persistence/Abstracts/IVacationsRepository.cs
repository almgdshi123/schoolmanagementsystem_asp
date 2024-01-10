using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IVacationsRepository : ICRUDRepository<VacationsTb>
    {

        public Task<List<VacationsTb>> GetListAsync();
    }

}
