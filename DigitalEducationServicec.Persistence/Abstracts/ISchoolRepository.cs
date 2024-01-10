using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISchoolRepository : ICRUDRepository<SchoolTb>
    {
        public Task<List<SchoolTb>> GetListAsync();

    }

}
