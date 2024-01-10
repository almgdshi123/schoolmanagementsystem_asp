using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IDocmunetsRepository : ICRUDRepository<DocmunetsTb>
    {

        public Task<List<DocmunetsTb>> GetListAsync();
    }

}

