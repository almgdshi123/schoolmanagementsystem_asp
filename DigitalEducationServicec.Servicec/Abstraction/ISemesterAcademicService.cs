using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISemesterAcademicService
    {
        public Task<List<SemesterAcademicTb>> GetSectionDataListAsync();
        public Task<SemesterAcademicTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SemesterAcademicTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(SemesterAcademicTb data);
        public Task<string> DeleteAsync(SemesterAcademicTb data);
    }
}
