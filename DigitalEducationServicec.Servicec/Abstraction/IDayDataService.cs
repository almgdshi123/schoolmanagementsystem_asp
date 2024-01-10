using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{


    public interface IDayDataService
    {
        public Task<List<DayDataTb>> GetDayDataListAsync();
        public Task<DayDataTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DayDataTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DayDataTb data);
        public Task<string> DeleteAsync(DayDataTb data);
    }


}
