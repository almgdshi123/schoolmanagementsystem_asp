using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ISectionCodeRepository : ICRUDRepository<SectionCodeTb>
    {

        public Task<List<SectionCodeTb>> GetListAsync();
    }

}