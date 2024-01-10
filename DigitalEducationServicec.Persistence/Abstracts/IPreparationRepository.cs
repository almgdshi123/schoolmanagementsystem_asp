using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IPreparationRepository : ICRUDRepository<PreparationTb>
    {

        public Task<List<PreparationTb>> GetListAsync();

    }

}
