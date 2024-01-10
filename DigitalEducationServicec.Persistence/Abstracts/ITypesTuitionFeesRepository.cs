using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ITypesTuitionFeesRepository : ICRUDRepository<TypesTuitionFeesTb>
    {

        public Task<List<TypesTuitionFeesTb>> GetListAsync();
    }

}
