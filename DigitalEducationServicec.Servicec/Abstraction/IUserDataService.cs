using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IUserDataService
    {
        public Task<List<UserDataTb>> GetUserDataListAsync();
        public Task<UserDataTb> GetByIDAsync(long id);
        public Task<string> AddAsync(UserDataTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(UserDataTb data);
        public Task<string> DeleteAsync(UserDataTb data);
        public IQueryable<UserDataTb> GetUserDataQuerable();

    }

}
