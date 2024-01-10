using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISemesterAcademicRepository : ICRUDRepository<SemesterAcademicTb>
    {

        public Task<List<SemesterAcademicTb>> GetListAsync();
    }

}
