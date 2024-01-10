using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISubjectRepository : ICRUDRepository<SubjectTb>
    {
        public Task<List<SubjectTb>> GetListAsync();

    }

}
