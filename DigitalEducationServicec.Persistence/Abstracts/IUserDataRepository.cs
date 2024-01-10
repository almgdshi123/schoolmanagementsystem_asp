

using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IUserDataRepository : ICRUDRepository<UserDataTb>
    {
        public Task<List<UserDataTb>> GetListAsync();

    }

}
