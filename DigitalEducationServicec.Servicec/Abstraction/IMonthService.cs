using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IMonthService
    {
        public Task<List<MonthTb>> GetMonthListAsync();
        public Task<MonthTb> GetByIDAsync(long id);
        public Task<string> AddAsync(MonthTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(MonthTb academicStatuses);
        public Task<string> DeleteAsync(MonthTb academicStatuses);
    }
}
