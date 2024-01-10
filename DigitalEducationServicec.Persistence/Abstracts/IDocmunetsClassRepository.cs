using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IDocmunetsClassRepository : ICRUDRepository<DocmunetsClassTb>
    {

        public Task<List<DocmunetsClassTb>> GetListAsync();
    }

}

