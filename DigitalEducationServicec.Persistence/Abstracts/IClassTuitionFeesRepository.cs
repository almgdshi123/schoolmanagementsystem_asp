using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IClassTuitionFeesRepository : ICRUDRepository<ClassTuitionFeesTb>
    {

        public Task<List<ClassTuitionFeesTb>> GetListAsync();
    }

}

