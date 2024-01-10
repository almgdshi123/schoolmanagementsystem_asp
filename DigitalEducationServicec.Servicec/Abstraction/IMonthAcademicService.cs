using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{

    public interface IMonthAcademicService
    {
        public Task<List<MonthAcademicTb>> GetMonthAcademicListAsync();
        public Task<MonthAcademicTb> GetByIDAsync(long id);
        public Task<string> AddAsync(MonthAcademicTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(MonthAcademicTb data);
        public Task<string> DeleteAsync(MonthAcademicTb data);
    }
}
