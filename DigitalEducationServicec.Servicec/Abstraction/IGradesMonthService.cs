using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IGradesMonthService
    {
        public Task<List<GradesMonthTb>> GetGradesMonthListAsync();
        public Task<GradesMonthTb> GetByIDAsync(long id);
        public Task<string> AddAsync(GradesMonthTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(GradesMonthTb data);
        public Task<string> DeleteAsync(GradesMonthTb data);
    }
}
