using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IYearDataService
    {
        public Task<List<YearDataTb>> GetYearDataListAsync();
        public Task<YearDataTb> GetByIDAsync(long id);
        public Task<string> AddAsync(YearDataTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(YearDataTb data);
        public Task<string> DeleteAsync(YearDataTb data);
        public IQueryable<YearDataTb> GetYearDataQuerable();
    }
}
