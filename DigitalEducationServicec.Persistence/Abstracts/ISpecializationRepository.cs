using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISpecializationRepository : ICRUDRepository<SpecializationTb>
    {
        public Task<List<SpecializationTb>> GetListAsync();
    }

}
