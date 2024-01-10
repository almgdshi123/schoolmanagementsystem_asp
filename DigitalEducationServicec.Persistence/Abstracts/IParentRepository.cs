using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IParentRepository : ICRUDRepository<ParentTb> {
        public Task<List<ParentTb>> GetParentListAsync();

    }
}

