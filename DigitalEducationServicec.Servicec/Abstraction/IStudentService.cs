using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Domain.Helpers;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStudentService
    {
        public Task<List<StudentTb>> GetStudentTbListAsync();
        public Task<StudentTb> GetStudentTbByIDWithIncludeAsync(int id);
        public Task<StudentTb> GetByIDAsync(long id);
        public Task<string> AddAsync(StudentTb data);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(StudentTb data);
        public Task<string> DeleteAsync(StudentTb data);
        public IQueryable<StudentTb> GetStudentsQuerable();
        public IQueryable<StudentTb> GetStudentsByParentTbIDQuerable(int DID);
        public IQueryable<StudentTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);
        //  public IQueryable<ParentTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);
    }
}
