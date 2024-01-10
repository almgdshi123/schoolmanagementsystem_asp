using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IGradesMonthRepository : ICRUDRepository<GradesMonthTb>
    {

        public Task<List<GradesMonthTb>> GetListAsync();

    }

}
