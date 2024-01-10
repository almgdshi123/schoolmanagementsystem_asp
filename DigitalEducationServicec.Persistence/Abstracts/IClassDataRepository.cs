using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IClassDataRepository : ICRUDRepository<ClassDataTb>
    {

        public Task<List<ClassDataTb>> GetListAsync();

    }

}
