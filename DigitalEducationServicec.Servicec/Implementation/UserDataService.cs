using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class UserDataService : IUserDataService
    {
        public Task<string> AddAsync(UserDataTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(UserDataTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditAsync(UserDataTb data)
        {
            throw new NotImplementedException();
        }

        public Task<UserDataTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDataTb>> GetUserDataListAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserDataTb> GetUserDataQuerable()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
