using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IMonthRepository : ICRUDRepository<MonthTb>
    {

        public Task<List<MonthTb>> GetListAsync();

    }

}
