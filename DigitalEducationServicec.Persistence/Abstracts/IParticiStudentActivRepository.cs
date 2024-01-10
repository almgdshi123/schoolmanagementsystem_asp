using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IParticiStudentActivRepository : ICRUDRepository<ParticiStudentActivTb>
    {

        public Task<List<ParticiStudentActivTb>> GetListAsync();
    }

}