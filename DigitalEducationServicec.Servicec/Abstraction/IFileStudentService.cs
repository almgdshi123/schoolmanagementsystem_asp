using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IFileStudentService
    {
        public Task<List<FileStudentTb>> GetFileStudentListAsync();
        public Task<FileStudentTb> GetByIDAsync(long id);
        public Task<string> AddAsync(FileStudentTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(FileStudentTb data);
        public Task<string> DeleteAsync(FileStudentTb data);
    }
}
