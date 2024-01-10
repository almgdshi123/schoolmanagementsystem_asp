using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStreetsService
    {
        public Task<List<StreetsTb>> GetStreetsListAsync();
        public Task<StreetsTb> GetByIDAsync(int id);
        public Task<string> AddAsync(StreetsTb data);
        public Task<bool> IsNameExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(StreetsTb data);
        public Task<string> DeleteAsync(StreetsTb data);
    }
}