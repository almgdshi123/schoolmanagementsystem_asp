using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IFinesRepository : ICRUDRepository<FinesTb>
    {

        public Task<List<FinesTb>> GetListAsync();
    }

}

