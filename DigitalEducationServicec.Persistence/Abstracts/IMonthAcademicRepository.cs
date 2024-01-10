using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IMonthAcademicRepository : ICRUDRepository<MonthAcademicTb>
    {
        public Task<List<MonthAcademicTb>> GetListAsync();

    }

}
