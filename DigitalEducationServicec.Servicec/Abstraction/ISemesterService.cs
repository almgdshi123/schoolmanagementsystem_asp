using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISemesterService
    {
        public Task<List<SemesterTb>> GetSemesterListAsync();
        public Task<SemesterTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SemesterTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(SemesterTb data);
        public Task<string> DeleteAsync(SemesterTb data);

    }
}
