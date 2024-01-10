using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IParticiStudentActivService
    {
        public Task<List<ParticiStudentActivTb>> GetParticiStudentActivListAsync();
        public Task<ParticiStudentActivTb> GetByIDAsync(long id);
        public Task<string> AddAsync(ParticiStudentActivTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(ParticiStudentActivTb data);
        public Task<string> DeleteAsync(ParticiStudentActivTb data);
    }

}
