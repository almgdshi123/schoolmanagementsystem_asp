using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IYearDataRepository : ICRUDRepository<YearDataTb>
    {
        public Task<List<YearDataTb>> GetListAsync();

    }

}
