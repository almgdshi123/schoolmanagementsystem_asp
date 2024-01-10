using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IDocmunetStudentRepository : ICRUDRepository<DocmunetStudentTb>
    {

        public Task<List<DocmunetStudentTb>> GetListAsync();
    }

}

