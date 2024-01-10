using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IJopTypeRepository : ICRUDRepository<JopTypeTb>
    {

        public Task<List<JopTypeTb>> GetListAsync();
    }

}

