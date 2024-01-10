using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IStageRepository : ICRUDRepository<StageTb>
    {

        public Task<List<StageTb>> GetListAsync();

    }

}
