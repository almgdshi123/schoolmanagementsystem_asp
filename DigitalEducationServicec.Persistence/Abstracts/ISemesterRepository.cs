using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISemesterRepository : ICRUDRepository<SemesterTb>
    {

        public Task<List<SemesterTb>> GetListAsync();

    }

}
