using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{


    public interface IParentService
    {
        public Task<List<ParentTb>> GetParentListAsync();
        public Task<ParentTb> GetParentByIDWithIncludeAsync(int id);
        public Task<ParentTb> GetByIDAsync(long id);
        public Task<string> AddAsync(ParentTb parent);
        public Task<bool> IsNameArExist(string nameAr);
        public Task<bool> IsNameEnExist(string nameEn);
        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id);
        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id);
        public Task<string> EditAsync(ParentTb parent);
        public Task<string> DeleteAsync(ParentTb parent);
        public IQueryable<ParentTb> GetStudentsQuerable();
        public IQueryable<ParentTb> GetStudentsByParentTbIDQuerable(int DID);
        //public IQueryable<ParentTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);
    }
}
