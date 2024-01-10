using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ITeacherService
    {
        public Task<List<TeacherTb>> GetTeacherTbTbListAsync();
        public Task<TeacherTb> GeTeacherTbTbByIDWithIncludeAsync(int id);
        public Task<TeacherTb> GetByIDAsync(long id);
        public Task<string> AddAsync(TeacherTb data);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(TeacherTb data);
        public Task<string> DeleteAsync(TeacherTb data);
        public IQueryable<TeacherTb> GetTeacherQuerable();
        public IQueryable<TeacherTb> GetTeacherByParentTbIDQuerable(int DID);
        //public IQueryable<ParentTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);
    }
}
