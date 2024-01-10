using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISchoolGroupRepository : ICRUDRepository<SchoolGroupTb>
    {
        public Task<List<SchoolGroupTb>> GetListAsync();

    }

}
